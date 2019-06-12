using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class UsuarioServices : ServiceBase<Usuario>
    {
        private readonly UsuarioRepository usuarioRepository;

        public UsuarioServices(UsuarioRepository usuarioRepository):base(usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
    }
}
