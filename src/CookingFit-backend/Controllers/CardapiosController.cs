using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingFit_backend.Controllers
{
    public class CardapiosController : Controller
    {
        private readonly AppDbContext _context;

        public CardapiosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Cardapios.ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            // Crie uma instância de Cardapio
            var cardapio = new Cardapio();

            // Definir os tipos de cardápio disponíveis
            cardapio.Cardapios = new List<SelectListItem>
            {
                new SelectListItem { Value = "Café da manhã", Text = "Café da manhã" },
                new SelectListItem { Value = "Lanche da manhã", Text = "Lanche da manhã" },
                new SelectListItem { Value = "Almoço", Text = "Almoço" },
                new SelectListItem { Value = "Lanche da tarde", Text = "Lanche da tarde" },
                new SelectListItem { Value = "Jantar", Text = "Jantar" }
            };

            // Recuperar os ingredientes do banco de dados
            var ingredientes = _context.Ingrediente.Select(i => new SelectListItem
            {
                Value = i.Id.ToString(),
                Text = i.Nome
            }).ToList();

            // Adicionar uma opção padrão para o dropdown de ingredientes
            ingredientes.Insert(0, new SelectListItem { Value = "", Text = "-- Selecione um ingrediente --" });

            // Definir a lista suspensa de ingredientes
            cardapio.Ingredientes = ingredientes;

            return View(cardapio);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Cardapio cardapio)
        {
            if (ModelState.IsValid)
            {
                // Obtenha o ID do usuário atualmente autenticado
                var usuarioIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Verifique se o ID do usuário é nulo ou vazio
                if (string.IsNullOrEmpty(usuarioIdString))
                {
                    usuarioIdString = User.Identity.Name;
                }

                // Verifique novamente se o ID do usuário é nulo ou vazio
                if (string.IsNullOrEmpty(usuarioIdString))
                {
                    ModelState.AddModelError(string.Empty, "Usuário não autenticado.");
                    return View(cardapio);
                }

                // Converta o ID do usuário para o tipo correto (int)
                if (!int.TryParse(usuarioIdString, out int usuarioId))
                {
                    ModelState.AddModelError(string.Empty, "ID de usuário inválido.");
                    return View(cardapio);
                }

                // Verifique se o usuário existe
                var usuario = await _context.Usuarios.FindAsync(usuarioId);
                if (usuario == null)
                {
                    ModelState.AddModelError(string.Empty, "Usuário não encontrado.");
                    return View(cardapio);
                }

                // Atribua o UsuarioId ao novo cardápio
                cardapio.UsuarioId = usuario.Id;

                // Adicione o novo cardápio ao contexto e salve as mudanças
                _context.Add(cardapio);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            // Se houver erros de validação, retorne a view com o modelo inválido
            // e os dropdowns preenchidos corretamente
            cardapio.Cardapios = new List<SelectListItem>
            {
                new SelectListItem { Value = "Café da manhã", Text = "Café da manhã" },
                new SelectListItem { Value = "Lanche da manhã", Text = "Lanche da manhã" },
                new SelectListItem { Value = "Almoço", Text = "Almoço" },
                new SelectListItem { Value = "Lanche da tarde", Text = "Lanche da tarde" },
                new SelectListItem { Value = "Jantar", Text = "Jantar" }
            };

            // Recuperar os ingredientes do banco de dados
            var ingredientes = _context.Ingrediente.Select(i => new SelectListItem
            {
                Value = i.Id.ToString(),
                Text = i.Nome
            }).ToList();

            // Adicionar uma opção padrão para o dropdown de ingredientes
            ingredientes.Insert(0, new SelectListItem { Value = "", Text = "-- Selecione um ingrediente --" });

            // Definir a lista suspensa de ingredientes
            cardapio.Ingredientes = ingredientes;

            return View(cardapio);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardapio = await _context.Cardapios.FirstOrDefaultAsync(m => m.Id == id);

            if (cardapio == null)
            {
                return NotFound();
            }

            return View(cardapio);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardapio = await _context.Cardapios.FindAsync(id);

            if (cardapio == null)
            {
                return NotFound();
            }

            _context.Cardapios.Remove(cardapio);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
