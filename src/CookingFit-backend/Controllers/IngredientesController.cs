using AspNetCore;
using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CookingFit_backend.Controllers
{
    public class IngredientesController : Controller
    {
        private readonly AppDbContext _context;

        public IngredientesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Ingrediente.Include(i => i.TipoIngrediente).ToListAsync();
            return View(dados);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Ingrediente.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Ingrediente ingrediente)
        {
            if (id != ingrediente.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingrediente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredienteExists(ingrediente.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ingrediente);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Ingrediente
                .Include(i => i.TipoIngrediente)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Ingrediente
                .Include(i => i.TipoIngrediente)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dados = await _context.Ingrediente.FindAsync(id);
            _context.Ingrediente.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateCarboidrato()
        {
            var ingrediente = new Ingrediente { Calorias = 150, Tipo = "Carboidratos" };
            return View(ingrediente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCarboidrato(Ingrediente ingrediente)
        {
            ingrediente.Calorias = 150;

            if (ModelState.IsValid)
            {
                _context.Add(ingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Log the errors
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                System.Diagnostics.Debug.WriteLine("Error: " + error.ErrorMessage);
            }

            return View(ingrediente);
        }

        public async Task<IActionResult> List(string tipo)
        {
            if (string.IsNullOrEmpty(tipo))
            {
                return RedirectToAction(nameof(Index), new { error = "Tipo de ingrediente inválido." });
            }

            var ingredientes = await _context.Ingrediente
                .Include(i => i.TipoIngrediente)
                .Where(i => i.TipoIngrediente.Tipo.ToLower() == tipo.ToLower())
                .ToListAsync();

            ViewData["Tipo"] = tipo;
            return View("ListGeneric", ingredientes);
        }

        private bool IngredienteExists(int id)
        {
            return _context.Ingrediente.Any(e => e.Id == id);
        }
    }
}