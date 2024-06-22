using CookingFit_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CookingFit_backend.Controllers
{
    public class ItemCardapiosController : Controller
    {
        private readonly AppDbContext _context;

        public ItemCardapiosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ItemCardapios
        public async Task<IActionResult> Index()
        {
              return View(await _context.ItemCardapio.ToListAsync());
        }

        // GET: ItemCardapios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ItemCardapio == null)
            {
                return NotFound();
            }

            var itemCardapio = await _context.ItemCardapio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemCardapio == null)
            {
                return NotFound();
            }

            return View(itemCardapio);
        }

        // GET: ItemCardapios/Create
        public async Task<IActionResult> Create()
        {
            // Definir a lista suspensa com os tipos de ingredientes e seus IDs correspondentes
            var tiposDeIngredientes = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Carboidratos" },
                new SelectListItem { Value = "2", Text = "Carnes e ovos" },
                new SelectListItem { Value = "3", Text = "Frutas" },
                new SelectListItem { Value = "4", Text = "Laticínios" },
                new SelectListItem { Value = "5", Text = "Legumes e Verduras" },
                new SelectListItem { Value = "6", Text = "Leguminosas" },
                new SelectListItem { Value = "7", Text = "Óleos e Gorduras" }
            };

            // Definir ViewBag.TipoIngredienteId com a lista suspensa
            ViewBag.TipoIngredienteId = tiposDeIngredientes;

            var tipoCardapioId = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Café da manhã" },
                new SelectListItem { Value = "2", Text = "Lanche da manhã" },
                new SelectListItem { Value = "3", Text = "Almoço" },
                new SelectListItem { Value = "4", Text = "Lanche da tarde" },
                new SelectListItem { Value = "5", Text = "Jantar" }
            };

            // Definir ViewBag.TipoIngredienteId com a lista suspensa
            ViewBag.TipoCardapioId = tipoCardapioId;

            // Inicializar ViewBag.IngredienteId_IC como uma lista vazia
            ViewBag.IngredienteId_IC = new List<SelectListItem>();


            return View();
        }

        // POST: ItemCardapios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemCardapio itemCardapio, int ingrediente)
        {
            if (ModelState.IsValid)
            {
                var TipoIngredienteIdItem = await _context.TipoIngrediente.FirstOrDefaultAsync(t => t.Id == itemCardapio.TipoIngredienteIdItem);

                if (TipoIngredienteIdItem == null)
                {
                    ModelState.AddModelError("TipoIngredienteId", "Tipo de ingrediente inválido.");
                    ViewBag.TipoIngredienteId = new SelectList(_context.TipoIngrediente, "Id", "Tipo", itemCardapio.TipoIngredienteIdItem);
                    return View(itemCardapio);
                }

                // Configurar as calorias com base no tipo de ingrediente
                switch (TipoIngredienteIdItem.Id)
                {
                    case 1: // Carboidratos
                        itemCardapio.CaloriasItem = 150;
                        break;
                    case 2: // Carnes e ovos
                        itemCardapio.CaloriasItem = 190;
                        break;
                    case 3: // Frutas
                        itemCardapio.CaloriasItem = 70;
                        break;
                    case 4: // Laticínios
                        itemCardapio.CaloriasItem = 120;
                        break;
                    case 5: // Legumes e Verduras
                        itemCardapio.CaloriasItem = 15;
                        break;
                    case 6: // Leguminosas
                        itemCardapio.CaloriasItem = 55;
                        break;
                    case 7: // Óleos e Gorduras
                        itemCardapio.CaloriasItem = 73;
                        break;
                    default:
                        itemCardapio.CaloriasItem = 0; // Pode ser um tratamento de erro ou um valor padrão
                        break;
                }

                _context.Add(itemCardapio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            // Se houver um erro de validação, recarregar o dropdown de Tipo de Ingrediente e Ingrediente
            ViewBag.TipoIngredienteId = new SelectList(_context.TipoIngrediente, "Id", "Tipo", itemCardapio.TipoIngredienteIdItem);
            return View(itemCardapio);
        }



        // GET: ItemCardapios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ItemCardapio == null)
            {
                return NotFound();
            }

            var itemCardapio = await _context.ItemCardapio.FindAsync(id);
            if (itemCardapio == null)
            {
                return NotFound();
            }
            return View(itemCardapio);
        }

        // POST: ItemCardapios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoIngredienteId,IngredienteId")] ItemCardapio itemCardapio)
        {
            if (id != itemCardapio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemCardapio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemCardapioExists(itemCardapio.Id))
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
            return View(itemCardapio);
        }

        // GET: ItemCardapios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ItemCardapio == null)
            {
                return NotFound();
            }

            var itemCardapio = await _context.ItemCardapio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemCardapio == null)
            {
                return NotFound();
            }

            return View(itemCardapio);
        }

        // POST: ItemCardapios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ItemCardapio == null)
            {
                return Problem("Entity set 'AppDbContext.ItemCardapio'  is null.");
            }
            var itemCardapio = await _context.ItemCardapio.FindAsync(id);
            if (itemCardapio != null)
            {
                _context.ItemCardapio.Remove(itemCardapio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemCardapioExists(int id)
        {
          return _context.ItemCardapio.Any(e => e.Id == id);
        }

        [HttpGet]
        public IActionResult GetIngredientesByTipo(int tipoIngredienteId)
        {
            var ingredientes = _context.Ingrediente
                .Where(i => i.TipoIngredienteId == tipoIngredienteId) // Corrigido para usar TipoIngredienteId
                .Select(i => new { id = i.Id, nome = i.Nome })
                .ToList();

            return Json(ingredientes);
        }


    }
}