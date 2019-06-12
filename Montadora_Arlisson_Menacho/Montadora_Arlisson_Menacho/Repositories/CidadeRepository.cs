using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Contexto;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>
    {
        private readonly MontadoraContexto db;

        public CidadeRepository(MontadoraContexto montadoraContexto):base(montadoraContexto)
        {
            this.db = montadoraContexto;
        }
      
    }
}
