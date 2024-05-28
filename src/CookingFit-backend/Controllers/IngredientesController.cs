using AspNetCore;
using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ingrediente ingrediente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
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
            var ingrediente = new Ingrediente { Calorias = 150, TipoIngrediente = new TipoIngrediente { Tipo = "Carboidratos" } };
            return View("Views_Ingredientes_ListGeneric");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCarboidrato(Ingrediente ingrediente)
        {
            ingrediente.Calorias = 150;

            var tipoIngrediente = await _context.TipoIngrediente.FirstOrDefaultAsync(t => t.Tipo == "Carboidratos");
            if (tipoIngrediente == null)
            {
                tipoIngrediente = new TipoIngrediente { Tipo = "Carboidratos" };
                _context.TipoIngrediente.Add(tipoIngrediente);
                await _context.SaveChangesAsync();
            }
            ingrediente.TipoIngrediente = tipoIngrediente;

            if (ModelState.IsValid)
            {
                _context.Add(ingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AspNetCore.Views_Ingredientes_ListGeneric));
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                System.Diagnostics.Debug.WriteLine("Error: " + error.ErrorMessage);
            }

            return RedirectToAction("ListGeneric");
        }


        public IActionResult CreateFrutas()
        {
            var ingrediente = new Ingrediente { Calorias = 70, TipoIngrediente = new TipoIngrediente { Tipo = "Frutas" } };
            return View("Views_Ingredientes_ListGeneric");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFrutas(Ingrediente ingrediente)
        {
            ingrediente.Calorias = 70;

            var tipoIngrediente = await _context.TipoIngrediente.FirstOrDefaultAsync(t => t.Tipo == "Frutas");
            if (tipoIngrediente == null)
            {
                tipoIngrediente = new TipoIngrediente { Tipo = "Frutas" };
                _context.TipoIngrediente.Add(tipoIngrediente);
                await _context.SaveChangesAsync();
            }
            ingrediente.TipoIngrediente = tipoIngrediente;

            if (ModelState.IsValid)
            {
                _context.Add(ingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AspNetCore.Views_Ingredientes_ListGeneric));
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                System.Diagnostics.Debug.WriteLine("Error: " + error.ErrorMessage);
            }

            return RedirectToAction("ListGeneric");
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