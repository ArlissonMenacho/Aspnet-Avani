using System;
using System.Collections.Generic;
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

        public DateTime DataNascimento
        {
            get => dataNascimento;
            set => dataNascimento = value;
        }

        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        public string Numero
        {
            get => numero;
            set => numero = value;
        }
        public string Orgaoexpedidor
        {
            get => orgaoexpedidor;
            set => orgaoexpedidor = value;
        }
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
