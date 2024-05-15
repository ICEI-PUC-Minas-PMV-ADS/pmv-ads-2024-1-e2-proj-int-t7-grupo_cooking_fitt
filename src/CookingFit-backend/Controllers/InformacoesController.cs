using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CookingFit_backend.Controllers
{
    public class InformacoesController : Controller
    {
        private readonly InformacaoThumbnailContext _context;
        public InformacoesController(InformacaoThumbnailContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var dados = await _context.Informacoes.ToListAsync();

            return View(dados);
        }

        public IActionResult Create() //Exibe um formulário
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Informacao informacao) //Add algo e salva no banco de dados
        {
            if (ModelState.IsValid)
            {
                _context.Informacoes.Add(informacao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(informacao);
        }
        public async Task<IActionResult> Edit(int? IdUsuario)
        {
            if (IdUsuario == null)
                return NotFound();

            var dados = await _context.Informacoes.FindAsync(IdUsuario);

            if (dados == null)
                return NotFound();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int IdUsuario, Informacao informacao)
        {
            if (IdUsuario == informacao.IdUsuario)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Informacoes.Update(informacao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }

        public async Task<IActionResult> Details(int? IdUsuario)
        {
            if (IdUsuario == null)
                return NotFound();
            var dados = await _context.Informacoes.FindAsync(IdUsuario);
            if (dados == null)
                return NotFound();
            return View(dados);
        }


        public async Task<IActionResult> Delete(int? IdUsuario)
        {
            if (IdUsuario == null)
                return NotFound();
            var dados = await _context.Informacoes.FindAsync(IdUsuario);
            if (dados == null)
                return NotFound();
            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? IdUsuario)
        {
            if (IdUsuario == null)
                return NotFound();
            var dados = await _context.Informacoes.FindAsync(IdUsuario);
            if (dados == null)
                return NotFound();
            _context.Informacoes.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
