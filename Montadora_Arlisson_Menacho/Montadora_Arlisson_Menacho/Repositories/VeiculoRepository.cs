using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class VeiculoRepository
    {
        private readonly MontadoraContexto db;

        public VeiculoRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Veiculo veiculo)
        {
            db.Veiculos.Add(veiculo);
            db.SaveChanges();
        }

        public void Delete(Veiculo veiculo)
        {
            db.Veiculos.Remove(veiculo);
            db.SaveChanges();
        }

        public IList<Veiculo> FindAll()
        {
            return db.Veiculos.ToList();
        }      

        public Veiculo GetbyId(int id)
        {
            return db.Veiculos.Find(id);
        }
    }
}
