using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class PecaRepository : RepositoryBase<Peca>
    {
        private readonly MontadoraContexto db;

        public PecaRepository(MontadoraContexto montadoraContexto):base(montadoraContexto)
        {
            this.db = montadoraContexto;
        }     

        public IList<Peca> getByDescricao(String descricao)
        {
            return db.Pecas.Where(p => p.Descricao.Contains(descricao)).ToList();

        }

    }
}
