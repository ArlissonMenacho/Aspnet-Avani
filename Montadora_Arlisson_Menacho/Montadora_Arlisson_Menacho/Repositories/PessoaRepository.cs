using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;


namespace Montadora_Arlisson_Menacho.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>
    {
        private readonly MontadoraContexto db;

        public PessoaRepository(MontadoraContexto montadoraContexto):base(montadoraContexto)
        {
            this.db = montadoraContexto;
        }      
    }
}
