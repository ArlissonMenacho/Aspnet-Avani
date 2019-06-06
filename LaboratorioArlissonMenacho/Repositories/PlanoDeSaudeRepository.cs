using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Contexto;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Repositories
{
    public class PlanoDeSaudeRepository : RepositoryBase<PlanoDeSaude>
    {
        private readonly LaboratorioContexto db;

        public PlanoDeSaudeRepository(LaboratorioContexto laboratorioContexto) :base(laboratorioContexto)
        {
            this.db = laboratorioContexto;
        }
       
        public IList<PlanoDeSaude> getByDescricao(String descricao)
        {
          return db.Planos.Where(p => p.Descricao.Contains(descricao)).ToList();
            
        }

    }

   
}
