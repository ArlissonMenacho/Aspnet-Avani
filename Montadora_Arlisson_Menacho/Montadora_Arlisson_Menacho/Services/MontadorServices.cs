using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Repositories;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Services
{
    public class MontadorServices : ServiceBase<Montador>
    {
        private readonly MontadorRepository MontadorRepository;

        public MontadorServices(MontadorRepository montadorRepository):base(montadorRepository)
        {
            this.MontadorRepository = montadorRepository;
        }
    }
}
