using LaboratorioArlissonMenacho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Contexto;

namespace LaboratorioArlissonMenacho.Repositories
{
    public class ExameRepository : RepositoryBase<Exame>
    {
        private readonly LaboratorioContexto db;

        public ExameRepository(LaboratorioContexto db):base(db)
        {
            this.db = db;
        }
    
    }
}
