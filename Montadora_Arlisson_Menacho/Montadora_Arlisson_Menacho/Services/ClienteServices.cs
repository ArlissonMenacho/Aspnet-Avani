using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class ClienteServices : ServiceBase<Cliente>
    {      
            private readonly ClienteRespository clienteRepository;

            public ClienteServices(ClienteRespository clienteRepository):base(clienteRepository)
            {
                this.clienteRepository = clienteRepository;
            }

            
        
    }
}
