using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Fornecedor : Pessoa
    {
        private string endereco;

        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
    }
}
