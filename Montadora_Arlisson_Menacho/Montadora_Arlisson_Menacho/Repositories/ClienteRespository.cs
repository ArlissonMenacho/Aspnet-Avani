using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class ClienteRespository
    {
        private readonly MontadoraContexto db;

        public ClienteRespository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }

        public void Delete(Cliente cliente)
        {
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }

        public IList<Cliente> FindAll()
        {
            return db.Clientes.ToList();
        }

        //public IList<Cliente> getByDescricao(String descricao)
        //{
        //    return db.Clientes.Where(p => p.Descricao.Contains(descricao)).ToList();

        //}

        public Cliente GetbyId(int id)
        {
            return db.Clientes.Find(id);
        }
    }
}
