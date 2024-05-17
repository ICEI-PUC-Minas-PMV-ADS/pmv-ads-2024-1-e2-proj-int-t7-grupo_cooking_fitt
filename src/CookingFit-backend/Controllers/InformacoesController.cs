using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CookingFit_backend.Controllers
{
    public class InformacoesController : Controller
    {
        private readonly AppDbContext _context;
        public InformacoesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var dados = await _context.InfoUser.ToListAsync();

            return View(dados);
        }

        public IActionResult Create() //Exibe um formulário
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Informacao InfoUser) //Add algo e salva no banco de dados
        {
            if (ModelState.IsValid)
            {
                _context.InfoUser.Add(InfoUser);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(InfoUser);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.InfoUser.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Informacao InfoUser)
        {
            if (id != InfoUser.IdInfo)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.InfoUser.Update(InfoUser);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                    return NotFound();
                var dados = await _context.InfoUser.FindAsync(id);
                if (dados == null)
                    return NotFound();
                return View(dados);
            }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.InfoUser.FindAsync(id);
            if (dados == null)
                return NotFound();
            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.InfoUser.FindAsync(id);
            if (dados == null)
                return NotFound();
            _context.InfoUser.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }

    }

