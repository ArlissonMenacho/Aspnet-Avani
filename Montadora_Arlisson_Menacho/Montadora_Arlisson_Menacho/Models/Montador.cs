using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Montador : Pessoa
    {
        private decimal salario;

        public decimal Salario
        {
            get => salario;
            set => salario = value;
        }
    }
}
