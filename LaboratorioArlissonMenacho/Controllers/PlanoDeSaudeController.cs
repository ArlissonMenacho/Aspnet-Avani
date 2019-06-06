using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaboratorioArlissonMenacho.Services;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        private readonly PlanoSaudeServices service;

        public PlanoDeSaudeController(PlanoSaudeServices service)
        {
            this.service = service;
        }

        //public IActionResult Listar()
        //{
        //    IList<PlanoDeSaude> lista =
        //    service.BuscarTodos();
        //    return View(lista);
        //}

        public JsonResult Listar()
        {
            return Json(service.BuscarTodos());
        }
        public IActionResult Lista()
        {
            return View(service.BuscarTodos());
        }
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(PlanoDeSaude plano)

        {
            if (ModelState.IsValid)
            {
                service.Adicionar(plano);
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("lista");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(plano);

        }
        public IActionResult Excluir(int id)
        {
            PlanoDeSaude plano = new PlanoDeSaude();
                service.buscarPorId(id);
                return View(plano);

        }
        [HttpPost]
        public IActionResult Excluir(PlanoDeSaude plano)
        {
            service.Apagar(plano);
            return RedirectToAction("lista");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}