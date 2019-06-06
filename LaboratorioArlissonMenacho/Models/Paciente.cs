using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioArlissonMenacho.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public  string  Nome{ get; set; }

        public DateTime DataNascimento { get; set; }

        public PlanoDeSaude PlanoDeSaude { get; set; }
    }
}
