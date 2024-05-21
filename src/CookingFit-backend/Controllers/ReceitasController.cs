using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CookingFit_backend.Models;

namespace CookingFit_backend.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly AppDbContext _context;

        public ReceitasController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var receitas = await _context.Receitas.ToListAsync();
              return View(receitas);
        }

        // GET: Receitas/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _context.Receitas == null)
            {
                return NotFound();
            }
            try
            {
                var receitas = await _context.Receitas
                             //   .Include(r => r.Comentarios) // Incluir os comentários
                                .FirstOrDefaultAsync(m => m.IdReceita == id);
            if (receitas == null)
            {
                return NotFound();
            }

            return View(receitas);
            }
            catch (Exception E)
            {

                throw E;
            }       
        }

            // GET: Receitas/Create
            public IActionResult Create()
        {
            return View();
        }

        // POST: Receitas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public async Task<IActionResult> Create([Bind("Nome,Código,Descriçao,Ativo")] Receitas receitas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receitas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receitas);
        }

        // GET: Receitas/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || _context.Receitas == null)
            {
                return NotFound();
            }

            var receitas = await _context.Receitas.FindAsync(id);
            if (receitas == null)
            {
                return NotFound();
            }
            return View(receitas);
        }

        // POST: Receitas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,IdReceita,Descriçao,Ativo")] Receitas receitas)
        {
            if (id != receitas.IdReceita)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receitas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceitasExists(receitas.IdReceita))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(receitas);
        }

        // GET: Receitas/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || _context.Receitas == null)
            {
                return NotFound();
            }

            var receitas = await _context.Receitas
                .FirstOrDefaultAsync(m => m.IdReceita == id);
            if (receitas == null)
            {
                return NotFound();
            }

            return View(receitas);
        }

        // POST: Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Receitas == null)
            {
                return Problem("Entity set 'AppDbContext.Receitas'  is null.");
            }
            var receitas = await _context.Receitas.FindAsync(id);
            if (receitas != null)
            {
                _context.Receitas.Remove(receitas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceitasExists(int id)
        {
          return _context.Receitas.Any(e => e.IdReceita == id);
        }
        [HttpPost]
        public async Task<IActionResult> AdicionarComentario(PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Criar um novo objeto de Comentario com os dados do PostModel
                    var comentario = new Comentario
                    {
                        Nota = postModel.nota,
                        IdReceita = postModel.IdReceita,
                        Texto = postModel.comentario
                    };

                    // Adicionar o comentário ao contexto e salvar as mudanças no banco de dados
                    _context.Comentarios.Add(comentario);
                    await _context.SaveChangesAsync();

                    // Redirecionar de volta à página de detalhes da receita
                    return RedirectToAction("Details", new { id = postModel.IdReceita });
                }
                catch (Exception ex)
                {
                    // Lidar com erros, se necessário
                    return BadRequest("Ocorreu um erro ao adicionar o comentário: " + ex.Message);
                }
            }

            // Se o modelo não for válido, redirecionar à página de detalhes da receita sem fazer alterações
            return RedirectToAction("Details", new { id = postModel.IdReceita });
        }

    }
}
