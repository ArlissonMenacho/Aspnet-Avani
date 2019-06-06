using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaboratorioArlissonMenacho.Services;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Controllers
{
    public class ExameController : Controller
    {
        private readonly ExameServices exameServices;

        public JsonResult BuscarTodos()
        {
            IList<Exame> lista = exameServices.BuscarTodos();
            return Json(lista);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}