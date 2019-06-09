using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Peca
    {
        private DateTime dtFabricacao;
        private string descricao;
        private string numeroSerie;
        private int pecaId;
        private decimal valor;
        Fornecedor objFornecedor;

        public DateTime DtFabricacao
        {
            get => dtFabricacao;
            set => dtFabricacao = value;
        }
        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }
        public string NumeroSerie
        {
            get => numeroSerie;
            set => numeroSerie = value;
        }
        public int PecaId
        {
            get => pecaId;
            set => pecaId = value;
        }
        public decimal Valor
        {
            get => valor;
            set => valor = value;
        }
        public Fornecedor ObjFornecedor
        {
            get => objFornecedor;
            set => objFornecedor = value;
        }
    }
}
