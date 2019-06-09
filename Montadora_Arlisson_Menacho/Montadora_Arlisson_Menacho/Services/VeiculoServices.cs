using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class VeiculoServices
    {
        private readonly  VeiculoRepository veiculoRepository;

        public VeiculoServices(VeiculoRepository veiculoRepository)
        {
            this.veiculoRepository = veiculoRepository;
        }

        public void Add(Veiculo veiculo)
        {
            veiculoRepository.Add(veiculo);
        }

        public void Delete(Veiculo veiculo)
        {
            veiculoRepository.Delete(veiculo);
        }

        public IList<Veiculo> FindAll()
        {
            return veiculoRepository.FindAll();
        }        

        public Veiculo GetbyId(int id)
        {
            return veiculoRepository.GetbyId(id);
        }
    }
}
