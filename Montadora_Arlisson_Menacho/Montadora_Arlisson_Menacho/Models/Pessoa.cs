using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Pessoa
    {
        private string cpf;
        private int id;
        private string nome;

        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
    }
}
