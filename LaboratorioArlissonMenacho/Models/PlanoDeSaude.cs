using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LaboratorioArlissonMenacho.Models
{
    public class PlanoDeSaude
    {
        [Display(Name ="ID")]
        public int PlanoDeSaudeId
        {
            get; set;
        }
        [Required]
        [Display(Name = "Razão Social")]
        public string RazaoSocial
        {
            get; set;
        }
        [Required]
        [Display(Name = "Descrição")]
        public string Descricao
        {
            get; set;
        }
    }
}
