using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Montador : Pessoa
    {
        private decimal salario;
        [Required]
        [Display(Name ="Salário")]
        public decimal Salario
        {
            get => salario;
            set => salario = value;
        }
    }
}
