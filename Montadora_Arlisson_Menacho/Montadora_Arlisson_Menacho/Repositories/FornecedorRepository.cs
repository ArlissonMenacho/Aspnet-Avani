using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>
    {
        private readonly MontadoraContexto db;

        public FornecedorRepository(MontadoraContexto montadoraContexto):base(montadoraContexto)
        {
            this.db = montadoraContexto;
        }      

    }
}
