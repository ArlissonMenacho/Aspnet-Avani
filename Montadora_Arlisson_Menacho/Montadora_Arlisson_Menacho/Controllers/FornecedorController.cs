using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Services;

namespace Montadora_Arlisson_Menacho.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly FornecedorServices service;

        public FornecedorController(FornecedorServices service)
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
        public IActionResult Novo(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                service.Adicionar(fornecedor);
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("lista");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(fornecedor);

        }
        public IActionResult Excluir(int id)
        {
            Fornecedor fornecedor = service.buscarPorId(id);
            return View(fornecedor);

        }
        [HttpPost]
        public IActionResult Excluir(Fornecedor fornecedor)
        {
            var fornecedores = service.buscarPorId(fornecedor.Id);
            service.Apagar(fornecedores);
            return RedirectToAction("lista");
        }
        public IActionResult Alterar(int id)
        {
            Fornecedor fornecedor = service.buscarPorId(id);
            return View(fornecedor);
        }
        [HttpPost]
        public IActionResult Alterar(Fornecedor fornecedor)
        {
            service.Alterar(fornecedor);
            return RedirectToAction("lista");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}