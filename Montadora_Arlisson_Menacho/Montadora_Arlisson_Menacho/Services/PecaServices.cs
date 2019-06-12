using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class PecaServices : ServiceBase<Peca>
    {       
            private readonly PecaRepository pecaRepository;

            public PecaServices(PecaRepository pecaRepository):base(pecaRepository)
            {
                this.pecaRepository = pecaRepository;
            }       
    }
}


