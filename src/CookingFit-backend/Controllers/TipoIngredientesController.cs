using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;


namespace CookingFit_backend.Controllers
{
    [Authorize]
    public class TipoIngredientesController : Controller
    {
        private readonly AppDbContext _context;
        public TipoIngredientesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.TipoIngrediente.ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            ViewBag.Tipos = new List<SelectListItem>
            {
                new SelectListItem { Value = "Carboidratos", Text = "Carboidratos" },
                new SelectListItem { Value = "Carnes e ovos", Text = "Carnes e ovos" },
                new SelectListItem { Value = "Frutas", Text = "Frutas" },
                new SelectListItem { Value = "Laticínios", Text = "Laticínios" },
                new SelectListItem { Value = "Legumes e Verduras", Text = "Legumes e Verduras" },
                new SelectListItem { Value = "Leguminosas", Text = "Leguminosas" },
                new SelectListItem { Value = "Óleos e Gorduras", Text = "Óleos e Gorduras" },
                // Adicione mais tipos conforme necessário
            };
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(TipoIngrediente tipoingrediente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            // Recarregar a lista de opções em caso de erro de validação
            ViewBag.Tipos = new List<SelectListItem>
            {
                new SelectListItem { Value = "Carboidratos", Text = "Carboidratos" },
                new SelectListItem { Value = "Carnes e ovos", Text = "Carnes e ovos" },
                new SelectListItem { Value = "Frutas", Text = "Frutas" },
                new SelectListItem { Value = "Laticínios", Text = "Laticínios" },
                new SelectListItem { Value = "Legumes e verduras", Text = "Legumes e Verduras" },
                new SelectListItem { Value = "Leguminosas", Text = "Leguminosas" },
                new SelectListItem { Value = "Óleos e gorduras", Text = "Óleos e Gorduras" },
                // Adicione mais tipos conforme necessário
            };
            return View(tipoingrediente);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.TipoIngrediente.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.TipoIngrediente.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.TipoIngrediente.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}

