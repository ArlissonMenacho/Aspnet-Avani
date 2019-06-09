using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class PecaServices
    {       
            private readonly PecaRepository pecaRepository;

            public PecaServices(PecaRepository pecaRepository)
            {
                this.pecaRepository = pecaRepository;
            }

            public void Add(Peca peca)
            {
                pecaRepository.Add(peca);
            }

            public void Delete(Peca peca)
            {
                pecaRepository.Delete(peca);
            }

            public IList<Peca> FindAll()
            {
                return pecaRepository.FindAll();
            }

            public IList<Peca> getByDescricao(String descricao)
            {
                return pecaRepository.getByDescricao(descricao);

            }

            public Peca GetbyId(int id)
            {
                return pecaRepository.GetbyId(id);
            }
        
    }
}


