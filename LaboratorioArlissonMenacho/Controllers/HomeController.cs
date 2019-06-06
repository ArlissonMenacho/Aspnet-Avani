using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaboratorioArlissonMenacho.Models;
using LaboratorioArlissonMenacho.Services;

namespace LaboratorioArlissonMenacho.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlanoSaudeServices planoDeSaudeServices;

        public HomeController(PlanoSaudeServices planoDeSaudeServices)
        {
            this.planoDeSaudeServices = planoDeSaudeServices;
        }

        //public HomeController(PlanoDeSaudeServices planoDeSaudeServices)
        //{
        //    this.planoDeSaudeServices = planoDeSaudeServices;
        //}

        public IActionResult Index()
        {
            IList<PlanoDeSaude> plano = planoDeSaudeServices.BuscarTodos();
            return View();

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
