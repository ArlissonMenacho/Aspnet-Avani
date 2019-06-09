using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class MontadorRepository
    {
        private readonly MontadoraContexto db;

        public MontadorRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Montador montador)
        {
            db.Montadores.Add(montador);
            db.SaveChanges();
        }

        public void Delete(Montador montador)
        {
            db.Montadores.Remove(montador);
            db.SaveChanges();
        }

        public IList<Montador> FindAll()
        {
            return db.Montadores.ToList();
        }

        //public IList<Montador> getByDescricao(String descricao)
        //{
        //    return db.Montadores.Where(p => p.Descricao.Contains(descricao)).ToList();

        //}

        public Montador GetbyId(int id)
        {
            return db.Montadores.Find(id);
        }
    }
}
