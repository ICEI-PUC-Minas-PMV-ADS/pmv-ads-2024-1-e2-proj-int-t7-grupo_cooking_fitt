using CookingFitDATA.Models;
using CookingFitDATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingFit.Web.Controllers
{
    public class UsuárioController1 : Controller
    {
        private UsuárioServices oUsuárioServices = new UsuárioServices();
        public IActionResult Index()
        {
            List<Usuário> oListUsuário = oUsuárioServices.oRepositoryUsuário.SelecionarTodos();
            return View(oListUsuário);
        }

        public IActionResult Create() 
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Usuário model)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            oUsuárioServices.oRepositoryUsuário.Incluir(model);
            return RedirectToAction("Index");

        }
    }
}
