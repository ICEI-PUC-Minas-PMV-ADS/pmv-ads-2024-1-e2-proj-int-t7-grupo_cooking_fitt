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

        public async Task<IActionResult> Select()
        {
            var ingredientes = await _context.Ingrediente.Select(i => new Ingrediente
            {
                Id = i.Id,
                Nome = i.Nome,
                Calorias = i.Calorias
            }).ToListAsync();

            return View(ingredientes);
        }

        // POST: CardapiosController/Select
        [HttpPost]
        public async Task<IActionResult> Select(List<int> selectedIngredienteIds)
        {
            if (ModelState.IsValid)
            {
                // Recupera os ingredientes selecionados
                var ingredientesSelecionados = await _context.Ingrediente
                    .Where(i => selectedIngredienteIds.Contains(i.Id))
                    .ToListAsync();

                // Calcula o total de calorias
                var totalCalorias = ingredientesSelecionados.Sum(i => i.Calorias);

                // Cria um novo objeto Cardapio e define os valores
                var cardapio = new Cardapio
                {
                    Descricao = "Cardápio", // Aqui você pode definir a descrição conforme necessário
                    Quantidade = selectedIngredienteIds.Count, // Defina a quantidade com base nos ingredientes selecionados
                    CaloriasCardapio = totalCalorias // Define o total de calorias
                };

                // Adiciona o cardápio ao contexto e salva as mudanças
                _context.Add(cardapio);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            // Se houver algum erro, recarrega a página com a lista de ingredientes
            var ingredientes = await _context.Ingrediente.ToListAsync();
            return View(ingredientes);
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