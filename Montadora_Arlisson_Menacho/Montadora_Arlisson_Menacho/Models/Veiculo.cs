using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [Display(Name ="Categoria")]
        public string Categoria
        {
            get => categoria;
            set => categoria = value;
        }
        [Required]
        [Display(Name ="Marca")]
        public string Marca
        {
            get => marca;
            set => marca = value;
        }
        [Required]
        [Display(Name = "Modelo")]
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        [Required]
        [Display(Name = "Veículo")]
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
