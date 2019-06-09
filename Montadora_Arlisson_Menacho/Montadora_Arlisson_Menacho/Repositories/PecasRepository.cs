using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class PecaRepository
    {
        private readonly MontadoraContexto db;

        public PecaRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Peca peca)
        {
            db.Pecas.Add(peca);
            db.SaveChanges();
        }

        public void Delete(Peca peca)
        {
            db.Pecas.Remove(peca);
            db.SaveChanges();
        }

        public IList<Peca> FindAll()
        {
            return db.Pecas.ToList();
        }

        public IList<Peca> getByDescricao(String descricao)
        {
            return db.Pecas.Where(p => p.Descricao.Contains(descricao)).ToList();

        }

        public Peca GetbyId(int id)
        {
            return db.Pecas.Find(id);
        }
    }
}
