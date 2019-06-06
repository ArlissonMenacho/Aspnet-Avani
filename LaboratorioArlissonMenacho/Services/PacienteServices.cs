using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Repositories;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Services
{
    public class PacienteServices : ServiceBase<Paciente>
    {
        private readonly PacienteRepository repository;

        public PacienteServices (PacienteRepository repository):base(repository)
        {
            this.repository = repository;
        }    
        
        public Paciente buscarPorNome(string nome)
        {
            return repository.BuscarPorNome(nome);
        }

    }
}
