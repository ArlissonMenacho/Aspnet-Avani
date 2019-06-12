using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Services;

namespace Montadora_Arlisson_Menacho.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteServices service;

        public ClienteController(ClienteServices service)
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
        public IActionResult Novo(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                service.Adicionar(cliente);
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("lista");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(cliente);

        }
        public IActionResult Excluir(int id)
        {
            Cliente cliente = service.buscarPorId(id);
            return View(cliente);

        }
        [HttpPost]
        public IActionResult Excluir(Cliente cliente)
        {
            var clientes = service.buscarPorId(cliente.Id);
            service.Apagar(clientes);
            return RedirectToAction("lista");
        }
        public IActionResult Alterar(int id)
        {
            Cliente cliente = service.buscarPorId(id);
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Alterar(Cliente cliente)
        {
            service.Alterar(cliente);
            return RedirectToAction("lista");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}