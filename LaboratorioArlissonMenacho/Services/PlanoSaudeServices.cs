using LaboratorioArlissonMenacho.Models;
using LaboratorioArlissonMenacho.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioArlissonMenacho.Services
{
    public class PlanoSaudeServices :ServiceBase<PlanoDeSaude>
    {
        private readonly PlanoDeSaudeRepository planoDeSaudeRepository;

        public PlanoSaudeServices(PlanoDeSaudeRepository planoDeSaudeRepository):base(planoDeSaudeRepository)
        {
            this.planoDeSaudeRepository = planoDeSaudeRepository;
        }
       
        public IList<PlanoDeSaude> BuscaDescricao(string descricao)
        {
           return planoDeSaudeRepository.getByDescricao(descricao); 

        }

       
    }
}
