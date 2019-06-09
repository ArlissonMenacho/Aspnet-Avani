using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;


namespace Montadora_Arlisson_Menacho.Repositories
{
    public class PessoaRepository
    {
        private readonly MontadoraContexto db;

        public PessoaRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Pessoa pessoa)
        {
            db.Pessoas.Add(pessoa);
            db.SaveChanges();
        }

        public void Delete(Pessoa pessoa)
        {
            db.Pessoas.Remove(pessoa);
            db.SaveChanges();
        }

        public IList<Pessoa> FindAll()
        {
            return db.Pessoas.ToList();
        }

        //public IList<Pessoa> getByDescricao(String descricao)
        //{
        //    return db.Pessoas.Where(p => p.Descricao.Contains(descricao)).ToList();

        //}

        public Pessoa GetbyId(int id)
        {
            return db.Pessoas.Find(id);
        }
    }
}
