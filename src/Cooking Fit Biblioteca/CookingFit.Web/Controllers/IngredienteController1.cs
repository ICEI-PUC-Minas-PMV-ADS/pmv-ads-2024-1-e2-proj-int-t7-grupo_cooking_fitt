using CookingFitDATA.Models;
using CookingFitDATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingFit.Web.Controllers
{
    public class IngredienteController1 : Controller
    {
        private IngredienteServices oIngredienteServices = new IngredienteServices();
        public IActionResult Index()
        {
            List<Ingrediente> oListIngrediente = oIngredienteServices.oRepositoryIngrediente.SelecionarTodos();
            return View(oListIngrediente);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Ingrediente model)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            oIngredienteServices.oRepositoryIngrediente.Incluir(model);
            return RedirectToAction("Index");

        }

    }
}
