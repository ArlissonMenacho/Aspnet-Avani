using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Contexto;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>
    {
        private readonly LaboratorioContexto db;

        public PacienteRepository (LaboratorioContexto db) :base(db)
        {
            this.db = db;
        }
        
        public Paciente BuscarPorNome (string nome)
        {
            return db.Pacientes.Find(nome);
        }


    }
}
