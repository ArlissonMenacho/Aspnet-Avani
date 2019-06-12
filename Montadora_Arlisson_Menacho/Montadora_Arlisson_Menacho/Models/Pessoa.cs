using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Pessoa
    {
        private string cpf;
        private int id;
        private string nome;

        [Required]
        [Display(Name = "CPF")]
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
        [Required]
        [Display(Name = "Nome")]
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
    }
}
