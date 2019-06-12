using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Cidade
    {
        private int cidadeid;
        private string nome;
        [Required]
        [Display(Name = "ID")]
        public int Id
        {
            get => cidadeid;
            set => cidadeid = value;
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
