using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Repositories
{
    public class UsuarioRepository
    {
        private readonly MontadoraContexto db;

        public UsuarioRepository(MontadoraContexto montadoraContexto)
        {
            this.db = montadoraContexto;
        }

        public void Add(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
        }

        public IList<Usuario> FindAll()
        {
            return db.Usuarios.ToList();
        }

        public Usuario GetbyId(int id)
        {
            return db.Usuarios.Find(id);
        }
    }
}
