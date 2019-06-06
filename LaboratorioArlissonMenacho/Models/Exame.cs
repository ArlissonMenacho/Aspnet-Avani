using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioArlissonMenacho.Models
{
    public class Exame
    {
        private int id;
        private string descricao;
        private string valor;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Valor { get => valor; set => valor = value; }
    }
}
