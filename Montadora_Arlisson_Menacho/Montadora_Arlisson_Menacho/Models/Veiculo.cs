using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Montadora_Arlisson_Menacho.Models
{
    public class Veiculo
    {
        private string categoria, marca, modelo;
        private int veiculoid;
        Usuario objUsuario;
        Cliente objCliente;
        Montador objMontador;
        IList<PecaDoVeiculo> listapecaDoVeiculos;

        public string Categoria
        {
            get => categoria;
            set => categoria = value;
        }
        public string Marca
        {
            get => marca;
            set => marca = value;
        }
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public int Veiculoid
        {
            get => veiculoid;
            set => veiculoid = value;
        }
        public Usuario ObjUsuario
        {
            get => objUsuario;
            set => objUsuario = value;
        }
        public Cliente ObjCliente
        {
            get => objCliente;
            set => objCliente = value;
        }
        public Montador ObjMontador
        {
            get => objMontador;
            set => objMontador = value;
        }
        public IList<PecaDoVeiculo> ListapecaDoVeiculos
        {
            get => listapecaDoVeiculos;
            set => listapecaDoVeiculos = value;
        }
    }
}
