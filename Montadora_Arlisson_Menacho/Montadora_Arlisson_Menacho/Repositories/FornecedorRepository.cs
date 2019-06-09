using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class FornecedorRepository
    {
        private readonly MontadoraContexto db;

        public FornecedorRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Fornecedor fornecedor)
        {
            db.Fornecedores.Add(fornecedor);
            db.SaveChanges();
        }

        public void Delete(Fornecedor fornecedor)
        {
            db.Fornecedores.Remove(fornecedor);
            db.SaveChanges();
        }

        public IList<Fornecedor> FindAll()
        {
            return db.Fornecedores.ToList();
        }

        //public IList<Fornecedor> getByDescricao(String descricao)
        //{
        //    return db.Fornecedores.Where(p => p.Descricao.Contains(descricao)).ToList();

        //}

        public Fornecedor GetbyId(int id)
        {
            return db.Fornecedores.Find(id);
        }
    }
}
