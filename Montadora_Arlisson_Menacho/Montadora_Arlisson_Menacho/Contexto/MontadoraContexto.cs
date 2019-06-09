using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Models;
using Microsoft.EntityFrameworkCore;

namespace Montadora_Arlisson_Menacho.Contexto
{
    public class MontadoraContexto : DbContext
    {
        public MontadoraContexto(DbContextOptions<MontadoraContexto> opcoes) : base(opcoes)
        {

        }

        public DbSet<Pessoa> Pessoas
        {
            get; set;
        }
        public DbSet<Peca> Pecas
        {
            get; set;
        }
        public DbSet<Cliente> Clientes
        {
            get; set;
        }
        public DbSet<Fornecedor> Fornecedores
        {
            get; set;
        }
        public DbSet<Cidade> Cidades
        {
            get; set;
        }
        public DbSet<Montador> Montadores
        {
            get; set;
        }
        public DbSet<Veiculo> Veiculos
        {
            get; set;
        }
        public DbSet<PecaDoVeiculo> PecaDosVeiculos
        {
            get; set;
        }
        public DbSet<Usuario> Usuarios
        {
            get; set;
        }

       

    }
}
