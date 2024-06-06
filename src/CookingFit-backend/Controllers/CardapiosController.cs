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
            var cardapio = new Cardapio();

            cardapio.Cardapios = new List<SelectListItem>
            {
                new SelectListItem { Value = "Café da manhã", Text = "Café da manhã" },
                new SelectListItem { Value = "Lanche da manhã", Text = "Lanche da manhã" },
                new SelectListItem { Value = "Almoço", Text = "Almoço" },
                new SelectListItem { Value = "Lanche da tarde", Text = "Lanche da tarde" },
                new SelectListItem { Value = "Jantar", Text = "Jantar" }
            };

            // Carregar os ingredientes do banco de dados
            var ingredientes = _context.Ingrediente.Select(i => new SelectListItem
            {
                Value = $"{i.Id}:{i.Calorias}", // Formatando o valor para incluir ID e Calorias
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
                var caloriasTotais = 0;
                foreach (var ingredienteId in cardapio.IngredientesIds)
                {
                    var ingrediente = await _context.Ingrediente.FindAsync(ingredienteId);
                    if (ingrediente != null)
                    {
                        caloriasTotais += ingrediente.Calorias;
                    }
                }
                cardapio.CaloriasCardapio = caloriasTotais;

                var usuarioIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(usuarioIdString))
                {
                    usuarioIdString = User.Identity.Name;
                }

                if (string.IsNullOrEmpty(usuarioIdString))
                {
                    ModelState.AddModelError(string.Empty, "Usuário não autenticado.");
                    return View(cardapio);
                }

                if (!int.TryParse(usuarioIdString, out int usuarioId))
                {
                    ModelState.AddModelError(string.Empty, "ID de usuário inválido.");
                    return View(cardapio);
                }

                var usuario = await _context.Usuarios.FindAsync(usuarioId);
                if (usuario == null)
                {
                    ModelState.AddModelError(string.Empty, "Usuário não encontrado.");
                    return View(cardapio);
                }

                cardapio.UsuarioId = usuario.Id;

                _context.Add(cardapio);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            cardapio.Cardapios = new List<SelectListItem>
            {
                new SelectListItem { Value = "Café da manhã", Text = "Café da manhã" },
                new SelectListItem { Value = "Lanche da manhã", Text = "Lanche da manhã" },
                new SelectListItem { Value = "Almoço", Text = "Almoço" },
                new SelectListItem { Value = "Lanche da tarde", Text = "Lanche da tarde" },
                new SelectListItem { Value = "Jantar", Text = "Jantar" }
            };

            // Carregar os ingredientes do banco de dados
            var ingredientes = _context.Ingrediente.Select(i => new SelectListItem
            {
                Value = $"{i.Id}:{i.Calorias}", // Formatando o valor para incluir ID e Calorias
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