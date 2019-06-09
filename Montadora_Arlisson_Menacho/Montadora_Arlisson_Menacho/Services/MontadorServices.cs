using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Repositories;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Services
{
    public class MontadorServices
    {
        private readonly MontadorRepository MontadorRepository;

        public MontadorServices(MontadorRepository montadorRepository)
        {
            this.MontadorRepository = montadorRepository;
        }

        public void Add(Montador montador)
        {
            MontadorRepository.Add(montador);
        }

        public void Delete(Montador montador)
        {
            MontadorRepository.Delete(montador);
        }

        public IList<Montador> FindAll()
        {
            return MontadorRepository.FindAll();
        }
               
        public Montador GetbyId(int id)
        {
            return MontadorRepository.GetbyId(id);
        }
    }
}
