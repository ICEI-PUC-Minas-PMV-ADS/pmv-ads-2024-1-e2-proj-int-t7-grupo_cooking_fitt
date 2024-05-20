using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;


namespace CookingFit_backend.Controllers
{
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
                new SelectListItem { Value = "Carneseovos", Text = "Carnes e Ovos" },
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
                new SelectListItem { Value = "Carneseovos", Text = "Carnes e Ovos" },
                new SelectListItem { Value = "Frutas", Text = "Frutas" },
                new SelectListItem { Value = "Laticínios", Text = "Laticínios" },
                new SelectListItem { Value = "Legumeseverduras", Text = "Legumes e Verduras" },
                new SelectListItem { Value = "Leguminosas", Text = "Leguminosas" },
                new SelectListItem { Value = "Óleosegorduras", Text = "Óleos e Gorduras" },
                // Adicione mais tipos conforme necessário
            };
            return View(tipoingrediente);
        }


    }
}
