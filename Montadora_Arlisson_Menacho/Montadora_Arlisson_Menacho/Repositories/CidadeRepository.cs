using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Contexto;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class CidadeRepository
    {
        private readonly MontadoraContexto db;

        public CidadeRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Cidade cidade)
        {
            db.Cidades.Add(cidade);
            db.SaveChanges();
        }

        public void Delete(Cidade cidade)
        {
            db.Cidades.Remove(cidade);
            db.SaveChanges();
        }

        public IList<Cidade> FindAll()
        {
            return db.Cidades.ToList();
        }

        //public IList<Cidade> getByDescricao(String descricao)
        //{
        //    return db.Cidades.Where(p => p.Descricao.Contains(descricao)).ToList();

        //}

        public Cidade GetbyId(int id)
        {
            return db.Cidades.Find(id);
        }
    }
}
