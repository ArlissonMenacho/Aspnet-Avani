using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class UsuarioServices
    {
        private readonly UsuarioRepository usuarioRepository;

        public UsuarioServices(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public void Add(Usuario usuario)
        {
            usuarioRepository.Add(usuario);
        }

        public void Delete(Usuario usuario)
        {
            usuarioRepository.Delete(usuario);
        }

        public IList<Usuario> FindAll()
        {
            return usuarioRepository.FindAll();
        }       

        public Usuario GetbyId(int id)
        {
            return usuarioRepository.GetbyId(id);
        }
    }
}
