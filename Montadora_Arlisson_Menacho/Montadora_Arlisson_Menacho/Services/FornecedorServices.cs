using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;

namespace Montadora_Arlisson_Menacho.Services
{
    public class FornecedorServices
    {
            private readonly FornecedorServices FornecedorRepository;

            public FornecedorServices(FornecedorServices FornecedorRepository)
            {
                this.FornecedorRepository = FornecedorRepository;
            }

            public void Add(Fornecedor fornecedor)
            {
                FornecedorRepository.Add(fornecedor);
            }

            public void Delete(Fornecedor fornecedor)
            {
                FornecedorRepository.Delete(fornecedor);
            }

            public IList<Fornecedor> FindAll()
            {
                return FornecedorRepository.FindAll();
            }

            public IList<Fornecedor> getByDescricao(String descricao)
            {
                return FornecedorRepository.getByDescricao(descricao);

            }

            public Fornecedor GetbyId(int id)
            {
                return FornecedorRepository.GetbyId(id);
            }
    }
    
}
