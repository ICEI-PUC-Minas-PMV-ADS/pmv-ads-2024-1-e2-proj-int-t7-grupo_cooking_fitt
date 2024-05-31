using CookingFit_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CookingFit_backend.Controllers
{
    [Authorize]
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

        public IActionResult Create()
        {
            // Definir a lista suspensa com os tipos de ingredientes e seus IDs correspondentes
            var tiposDeIngredientes = new List<SelectListItem>
            {
                new SelectListItem { Value = "8", Text = "Carboidratos" },
                new SelectListItem { Value = "9", Text = "Carnes e ovos" },
                new SelectListItem { Value = "10", Text = "Frutas" },
                new SelectListItem { Value = "11", Text = "Laticínios" },
                new SelectListItem { Value = "13", Text = "Legumes e Verduras" },
                new SelectListItem { Value = "14", Text = "Leguminosas" },
                new SelectListItem { Value = "15", Text = "Óleos e Gorduras" }
            };

            // Definir ViewBag.TipoIngredienteId com a lista suspensa
            ViewBag.TipoIngredienteId = tiposDeIngredientes;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ingrediente ingrediente)
        {
            if (ModelState.IsValid)
            {
                var tipoIngrediente = await _context.TipoIngrediente.FirstOrDefaultAsync(t => t.Id == ingrediente.TipoIngredienteId);

                if (tipoIngrediente == null)
                {
                    ModelState.AddModelError("TipoIngredienteId", "Tipo de ingrediente inválido.");
                    ViewBag.TipoIngredienteId = new SelectList(_context.TipoIngrediente, "Id", "Tipo", ingrediente.TipoIngredienteId);
                    return View(ingrediente);
                }

                // Configurar as calorias com base no tipo de ingrediente
                switch (tipoIngrediente.Id)
                {
                    case 8: // Carboidratos
                        ingrediente.Calorias = 150;
                        break;
                    case 9: // Carnes e ovos
                        ingrediente.Calorias = 190;
                        break;
                    case 10: // Frutas
                        ingrediente.Calorias = 70;
                        break;
                    case 11: // Laticínios
                        ingrediente.Calorias = 120;
                        break;
                    case 13: // Legumes e Verduras
                        ingrediente.Calorias = 15;
                        break;
                    case 14: // Leguminosas
                        ingrediente.Calorias = 55;
                        break;
                    case 15: // Óleos e Gorduras
                        ingrediente.Calorias = 73;
                        break;
                    default:
                        ingrediente.Calorias = 0; // Pode ser um tratamento de erro ou um valor padrão
                        break;
                }

                _context.Add(ingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            // Se houver um erro de validação, recarregar o dropdown de Tipo de Ingrediente
            ViewBag.TipoIngredienteId = new SelectList(_context.TipoIngrediente, "Id", "Tipo", ingrediente.TipoIngredienteId);
            return View(ingrediente);
        }



        public async Task<IActionResult> ListaCarboidrato(int? tipoIngredienteId)
        {
            var tiposDeIngredientes = new List<SelectListItem>
            {
                new SelectListItem { Value = "8", Text = "Carboidratos" },
                new SelectListItem { Value = "9", Text = "Carnes e ovos" },
                new SelectListItem { Value = "10", Text = "Frutas" },
                new SelectListItem { Value = "11", Text = "Laticínios" },
                new SelectListItem { Value = "13", Text = "Legumes e Verduras" },
                new SelectListItem { Value = "14", Text = "Leguminosas" },
                new SelectListItem { Value = "15", Text = "Óleos e Gorduras" }
            };

            ViewBag.TipoIngredienteId = new SelectList(tiposDeIngredientes, "Value", "Text");

            var ingredientes = _context.Ingrediente.Include(i => i.TipoIngrediente).AsQueryable();

            if (tipoIngredienteId.HasValue)
            {
                ingredientes = ingredientes.Where(i => i.TipoIngredienteId == tipoIngredienteId.Value);
            }

            return View(await ingredientes.ToListAsync());
        }





        public async Task<IActionResult> ListAA(string tipo)
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