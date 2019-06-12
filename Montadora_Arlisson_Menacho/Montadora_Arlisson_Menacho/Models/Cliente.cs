using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Cliente : Pessoa
    {
        private DateTime dataNascimento;
        private string endereco;
        private string numero;
        private string orgaoexpedidor;
        private string rg;
        Cidade objCidade;

        [Required]
        [Display(Name = "Data De Nascimento")]
        public DateTime DataNascimento
        {
            get => dataNascimento;
            set => dataNascimento = value;
        }
        [Required]
        [Display(Name = "Endereço")]
        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        [Required]
        [Display(Name = "Número")]
        public string Numero
        {
            get => numero;
            set => numero = value;
        }
        [Required]
        [Display(Name = "Orgão Expedidor")]
        public string Orgaoexpedidor
        {
            get => orgaoexpedidor;
            set => orgaoexpedidor = value;
        }
        [Required]
        [Display(Name = "RG")]
        public string Rg
        {
            get => rg;
            set => rg = value;
        }
        
        public Cidade ObjCidade
        {
            get => objCidade;
            set => objCidade = value;
        }
    }
}
