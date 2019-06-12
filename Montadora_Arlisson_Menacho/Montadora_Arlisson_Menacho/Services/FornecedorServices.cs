using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class FornecedorServices : ServiceBase<Fornecedor>
    {
            private readonly FornecedorRepository FornecedorRepository;

            public FornecedorServices(FornecedorRepository FornecedorRepository):base(FornecedorRepository)
            {
                this.FornecedorRepository = FornecedorRepository;
            }        
    }
    
}
