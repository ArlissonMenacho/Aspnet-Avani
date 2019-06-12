using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Services;

namespace Montadora_Arlisson_Menacho.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly VeiculoServices service;

        public VeiculoController(VeiculoServices service)
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
        public IActionResult Novo(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                service.Adicionar(veiculo);
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("lista");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(veiculo);

        }
        public IActionResult Excluir(int id)
        {
            Veiculo veiculo = service.buscarPorId(id);
            return View(veiculo);

        }
        [HttpPost]
        public IActionResult Excluir(Veiculo veiculo)
        {
            var veiculos = service.buscarPorId(veiculo.Veiculoid);
            service.Apagar(veiculos);
            return RedirectToAction("lista");
        }
        public IActionResult Alterar(int id)
        {
            Veiculo veiculo = service.buscarPorId(id);
            return View(veiculo);
        }
        [HttpPost]
        public IActionResult Alterar(Veiculo veiculo)
        {
            service.Alterar(veiculo);
            return RedirectToAction("lista");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}