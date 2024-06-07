using CookingFit_backend.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingFit_backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();

        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var dados = await _context.Usuarios
                .SingleOrDefaultAsync(u => u.Name == usuario.Name); // Alterado para pesquisar por Name

            if (dados == null || !BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha))
            {
                ViewBag.Message = "Usuário e/ou senha inválido(s)!";
                return View();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, dados.Name),
                new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString()),
                new Claim(ClaimTypes.Role, dados.Perfil.ToString())
            };

            var usuarioIdentity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

            var props = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(principal, props);

            return RedirectToAction("Index", "Home"); // Certifique-se que há uma ação Index no controlador Home
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
