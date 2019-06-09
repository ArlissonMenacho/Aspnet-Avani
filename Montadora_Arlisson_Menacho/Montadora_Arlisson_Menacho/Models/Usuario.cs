using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Usuario
    {
        private string senha;
        private int usuarioid;
        private string login;
        private string nome;

        public string Login
        {
            get => login;
            set => login = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Senha
        {
            get => senha;
            set => senha = value;
        }
        public int Usuarioid
        {
            get => usuarioid;
            set => usuarioid = value;
        }
    }
}
