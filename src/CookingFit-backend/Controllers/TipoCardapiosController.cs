using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;

namespace CookingFit_backend.Controllers
{
    public class TipoCardapiosController : Controller
    {
        private readonly AppDbContext _context;
        public TipoCardapiosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TipoCardapiosController
        public async Task<IActionResult> Index()
        {
            var tipoCardapio = await _context.TipoCardapio.ToListAsync();
            return View(tipoCardapio);
        }

        // GET: TipoCardapiosController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var tipoCardapio = await _context.TipoCardapio.FindAsync(id);
            if (tipoCardapio == null)
            {
                return NotFound();
            }
            return View(tipoCardapio);
        }

        // GET: TipoCardapiosController/Create
        public IActionResult Create()
        {
            ViewBag.Tipos = new List<SelectListItem>
            {
                new SelectListItem { Value = "Café da manhã", Text = "Café da manhã" },
                new SelectListItem { Value = "Lanche da manhã", Text = "Lanche da manhã" },
                new SelectListItem { Value = "Almoço", Text = "Almoço" },
                new SelectListItem { Value = "Lanche da tarde", Text = "Lanche da tarde" },
                new SelectListItem { Value = "Jantar", Text = "Jantar" },

                // Adicione mais tipos conforme necessário
            };
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tipo")] TipoCardapio tipoCardapio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoCardapio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Tipos = new List<SelectListItem>
        {
            new SelectListItem { Value = "Café da manhã", Text = "Café da manhã" },
            new SelectListItem { Value = "Lanche da manhã", Text = "Lanche da manhã" },
            new SelectListItem { Value = "Almoço", Text = "Almoço" },
            new SelectListItem { Value = "Lanche da tarde", Text = "Lanche da tarde" },
            new SelectListItem { Value = "Jantar", Text = "Jantar" },
        };
            return View(tipoCardapio);
        }

        // GET: TipoCardapiosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoCardapiosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoCardapiosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoCardapiosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
