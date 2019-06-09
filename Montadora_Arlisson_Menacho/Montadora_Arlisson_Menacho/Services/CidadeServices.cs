using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class CidadeServices
    {
        private readonly CidadeRepository cidadeRepository;

        public CidadeServices(CidadeRepository cidadeRepository)
        {
            this.cidadeRepository = cidadeRepository;
        }

        public void Add(Cidade cidade)
        {
            cidadeRepository.Add(cidade);
        }

        public void Delete(Cidade cidade)
        {
            cidadeRepository.Delete(cidade);
        }

        public IList<Cidade> FindAll()
        {
            return cidadeRepository.FindAll();
        }

        //public IList<Cidade> getByDescricao(String descricao)
        //{
        //    return cidadeRepository.getByDescricao(descricao);

        //}

        public Cidade GetbyId(int id)
        {
            return cidadeRepository.GetbyId(id);
        }
    }
}
