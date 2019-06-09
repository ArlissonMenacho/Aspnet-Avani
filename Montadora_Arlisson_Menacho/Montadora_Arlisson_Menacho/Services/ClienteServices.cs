using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Services
{
    public class ClienteServices
    {      
            private readonly ClienteServices ClienteRepository;

            public ClienteServices(ClienteServices ClienteRepository)
            {
                this.ClienteRepository = ClienteRepository;
            }

            public void Add(Cliente cliente)
            {
                ClienteRepository.Add(cliente);
            }

            public void Delete(Cliente cliente)
            {
                ClienteRepository.Delete(cliente);
            }

            public IList<Cliente> FindAll()
            {
                return ClienteRepository.FindAll();
            }

            public IList<Cliente> getByDescricao(String descricao)
            {
                return ClienteRepository.getByDescricao(descricao);

            }

            public Cliente GetbyId(int id)
            {
                return ClienteRepository.GetbyId(id);
            }
        
    }
}
