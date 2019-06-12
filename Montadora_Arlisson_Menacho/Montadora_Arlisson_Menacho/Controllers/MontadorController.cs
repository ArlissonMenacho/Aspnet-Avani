using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Services;

namespace Montadora_Arlisson_Menacho.Controllers
{
    public class MontadorController : Controller
    {
        private readonly MontadorServices service;

        public MontadorController(MontadorServices service)
        {
            this.service = service;
        }

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
        public IActionResult Novo(Montador montador)
        {
            if (ModelState.IsValid)
            {
                service.Adicionar(montador);
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("lista");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(montador);

        }
        public IActionResult Excluir(int id)
        {
            Montador montador = service.buscarPorId(id);
            return View(montador);

        }
        [HttpPost]
        public IActionResult Excluir(Montador montador)
        {
            var montadores = service.buscarPorId(montador.Id);
            service.Apagar(montadores);
            return RedirectToAction("lista");
        }
        public IActionResult Alterar(int id)
        {
            Montador montador = service.buscarPorId(id);
            return View(montador);
        }
        [HttpPost]
        public IActionResult Alterar(Montador montador)
        {
            service.Alterar(montador);
            return RedirectToAction("lista");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}