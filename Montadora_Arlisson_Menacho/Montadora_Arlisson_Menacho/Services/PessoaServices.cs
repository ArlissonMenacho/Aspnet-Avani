using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class PessoaServices
    {
        private readonly PessoaRepository PessoaRepository;

        public PessoaServices(PessoaRepository pessoaRepository)
        {
            this.PessoaRepository = pessoaRepository;
        }

        public void Add(Pessoa pessoa)
        {
            PessoaRepository.Add(pessoa);
        }

        public void Delete(Pessoa pessoa)
        {
            PessoaRepository.Delete(pessoa);
        }

        public IList<Pessoa> FindAll()
        {
            return PessoaRepository.FindAll();
        }
        
        public Pessoa GetbyId(int id)
        {
            return PessoaRepository.GetbyId(id);
        }
    }
}
