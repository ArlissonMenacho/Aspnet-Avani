using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class PecaDoVeiculoServices : ServiceBase<PecaDoVeiculo>
    {
        private readonly PecaDoVeiculoRepository pecaDoVeiculoRepository;

        public PecaDoVeiculoServices(PecaDoVeiculoRepository pecaDoVeiculoRepository):base(pecaDoVeiculoRepository)
        {
            this.pecaDoVeiculoRepository = pecaDoVeiculoRepository;
        }
    }
}
