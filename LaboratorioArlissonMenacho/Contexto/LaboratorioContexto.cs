using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Models;

namespace LaboratorioArlissonMenacho.Contexto
{
    public class LaboratorioContexto : DbContext
    {
         public DbSet<PlanoDeSaude> Planos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Exame> Exames { get; set; }

        public LaboratorioContexto(DbContextOptions<LaboratorioContexto> opcoes) : base(opcoes)
        {

        }

    }
}
