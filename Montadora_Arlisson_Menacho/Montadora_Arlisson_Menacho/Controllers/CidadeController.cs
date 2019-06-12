using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Services;

namespace Montadora_Arlisson_Menacho.Controllers
{
    public class CidadeController : Controller
    {
        private readonly CidadeServices service;

        public CidadeController(CidadeServices service)
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
        public IActionResult Novo(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                service.Adicionar(cidade);
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("lista");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(cidade);

        }
        public IActionResult Excluir(int id)
        {
            Cidade cidade = service.buscarPorId(id);
            return View(cidade);

        }
        [HttpPost]
        public IActionResult Excluir(Cidade cidade)
        {
            var cidades = service.buscarPorId(cidade.Id);
            service.Apagar(cidades);
            return RedirectToAction("lista");
        }
        public IActionResult Alterar(int id)
        {
            Cidade cidade = service.buscarPorId(id);
            return View(cidade);
        }
        [HttpPost]
        public IActionResult Alterar(Cidade cidade)
        {
            service.Alterar(cidade);
            return RedirectToAction("lista");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}