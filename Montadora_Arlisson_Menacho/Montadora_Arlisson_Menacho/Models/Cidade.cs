using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Cidade
    {
        private int cidadeid;
        private string nome;

        public int Cidadeid
        {
            get => cidadeid;
            set => cidadeid = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
    }
}
