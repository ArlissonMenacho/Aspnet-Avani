using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;


namespace Montadora_Arlisson_Menacho.Repositories
{
    public class PecaDoVeiculoRepository
    {
        private readonly MontadoraContexto db;

        public PecaDoVeiculoRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(PecaDoVeiculo pecaDoVeiculo)
        {
            db.PecaDosVeiculos.Add(pecaDoVeiculo);
            db.SaveChanges();
        }

        public void Delete(PecaDoVeiculo pecaDoVeiculo)
        {
            db.PecaDosVeiculos.Remove(pecaDoVeiculo);
            db.SaveChanges();
        }

        public IList<PecaDoVeiculo> FindAll()
        {
            return db.PecaDosVeiculos.ToList();
        }

        //public IList<PecaDoVeiculo> getByDescricao(String descricao)
        //{
        //    return db.PecaDosVeiculos.Where(p => p.Descricao.Contains(descricao)).ToList();

        //}

        public PecaDoVeiculo GetbyId(int id)
        {
            return db.PecaDosVeiculos.Find(id);
        }
    }
}
