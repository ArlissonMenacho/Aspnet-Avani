using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Services;

namespace Montadora_Arlisson_Menacho.Controllers
{
    public class HomeController : Controller
    {
        //private readonly CidadeServices cidadeServices;

        //public HomeController(CidadeServices cidadeServices)
        //{
        //    this.cidadeServices = cidadeServices;
        //}

        //private readonly ClienteServices clienteServices;

        //public HomeController(ClienteServices clienteServices)
        //{
        //    this.clienteServices = clienteServices;
        //}

        //private readonly FornecedorServices fornecedorServices;

        //public HomeController(FornecedorServices fornecedorServices)
        //{
        //    this.fornecedorServices = fornecedorServices;
        //}

        //private readonly MontadorServices montadorServices;

        //public HomeController(MontadorServices montadorServices)
        //{
        //    this.montadorServices = montadorServices;
        //}

        //private readonly PecaDoVeiculoServices pecaDoVeiculoServices;

        //public HomeController(PecaDoVeiculoServices pecaDoVeiculoServices)
        //{
        //    this.pecaDoVeiculoServices = pecaDoVeiculoServices;
        //}

        //private readonly PecaServices pecaServices;

        //public HomeController(PecaServices pecaServices)
        //{
        //    this.pecaServices = pecaServices;
        //}

        //private readonly PessoaServices pessoaServices;

        //public HomeController(PessoaServices pessoaServices)
        //{
        //    this.pessoaServices = pessoaServices;
        //}

        //private readonly UsuarioServices usuarioServices;

        //public HomeController(UsuarioServices usuarioServices)
        //{
        //    this.usuarioServices = usuarioServices;
        //}

        //private readonly VeiculoServices veiculoServices;

        //public HomeController(VeiculoServices veiculoServices)
        //{
        //    this.veiculoServices = veiculoServices;
        //}


        public IActionResult Index()
        {
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
