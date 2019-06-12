using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Fornecedor : Pessoa
    {
        private string endereco;
        [Required]
        [Display(Name = "Endereço")]
        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
    }
}
