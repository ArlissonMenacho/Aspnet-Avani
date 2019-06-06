using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Contexto;
using LaboratorioArlissonMenacho.Models;
using LaboratorioArlissonMenacho.Repositories;

namespace LaboratorioArlissonMenacho.Services
{
    public class ExameServices : ServiceBase<Exame>
    {
        private readonly ExameRepository repository;

        public ExameServices(ExameRepository repository):base(repository)
        {
            this.repository = repository;
        }

    }
}
