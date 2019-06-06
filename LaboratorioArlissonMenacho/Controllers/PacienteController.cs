using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaboratorioArlissonMenacho.Services;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Controllers
{
    public class PacienteController : Controller
    {
        private readonly PacienteServices pacienteServices;

        public PacienteController(PacienteServices pacienteServices)
        {
            this.pacienteServices = pacienteServices;
        }

        public JsonResult BuscarPorNome (string nome)
        {
               return Json(pacienteServices.buscarPorNome(nome));
        
        }

        public JsonResult Index()
        {
            IList<Paciente> lista = pacienteServices.BuscarTodos();
            return Json(lista);
        }
    }
}