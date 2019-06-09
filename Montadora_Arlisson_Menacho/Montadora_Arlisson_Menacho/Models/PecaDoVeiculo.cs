using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class PecaDoVeiculo
    {
        private decimal desconto;
        private int pecadoVeiculoId;
        private int quantidade;
        Peca objPeca;

        public decimal Desconto
        {
            get => desconto;
            set => desconto = value;
        }
        public int PecadoVeiculoId
        {
            get => pecadoVeiculoId;
            set => pecadoVeiculoId = value;
        }
        public int Quantidade
        {
            get => quantidade;
            set => quantidade = value;
        }
        public Peca ObjPeca
        {
            get => objPeca;
            set => objPeca = value;
        }
    }
}
