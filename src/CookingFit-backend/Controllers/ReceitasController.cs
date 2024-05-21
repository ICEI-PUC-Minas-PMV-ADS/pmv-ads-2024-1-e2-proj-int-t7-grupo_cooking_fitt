using CookingFit_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var dados = await _context.Receitas.ToListAsync();

            return View(dados);
        }
    }
} 
            
    

