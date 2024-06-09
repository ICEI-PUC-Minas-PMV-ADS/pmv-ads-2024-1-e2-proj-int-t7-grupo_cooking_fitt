using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using CookingFit_backend.Models.ViewModels;

namespace CookingFit_backend.Controllers
{
    [Authorize]
    public class CardapiosController : Controller
    {
        private readonly AppDbContext _context;

        public CardapiosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cardapios = await _context.Cardapios.ToListAsync();
            return View(cardapios);
        }

        public async Task<IActionResult> Select()
        {
            var ingredientes = await _context.Ingrediente
                .ToListAsync();

            return View(ingredientes);
        }

        [HttpPost]
        public async Task<IActionResult> Select(List<int> selectedIngredienteIds)
        {
            if (ModelState.IsValid)
            {
                if (selectedIngredienteIds != null && selectedIngredienteIds.Count > 0)
                {
                    // Lógica para calcular total de calorias e criar o novo cardápio

                    // Redireciona para a ação "Index" após adicionar o cardápio
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Selecione pelo menos um ingrediente.");
                }
            }

            // Se houver erros de validação ou nenhum ingrediente selecionado, recarrega a página com a lista de ingredientes
            var ingredientes = await _context.Ingrediente.ToListAsync();
            return View(ingredientes);
        }


        // POST: Cardapios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao")] Cardapio cardapio, List<int> selectedIngredienteIds)
        {
            if (ModelState.IsValid)
            {
                if (selectedIngredienteIds != null && selectedIngredienteIds.Count > 0)
                {
                    var ingredientesSelecionados = await _context.Ingrediente
                        .Where(i => selectedIngredienteIds.Contains(i.Id))
                        .ToListAsync();

                    cardapio.QuantidadeCardapio = selectedIngredienteIds.Count;
                    cardapio.CaloriasCardapio = ingredientesSelecionados.Sum(i => i.Calorias);

                    _context.Cardapios.Add(cardapio);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Você deve selecionar pelo menos um ingrediente.");
                }
            }

            ViewBag.TipoIngredienteId = new SelectList(await _context.TipoIngrediente.ToListAsync(), "Id", "Tipo");
            ViewBag.Ingredientes = await _context.Ingrediente.ToListAsync();
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

        // GET: Cardapios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardapio = await _context.Cardapios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cardapio == null)
            {
                return NotFound();
            }

            return View(cardapio);
        }

    }
}