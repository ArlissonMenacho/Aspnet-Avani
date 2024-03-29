﻿// <auto-generated />
using System;
using LaboratorioArlissonMenacho.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaboratorioArlissonMenacho.Migrations
{
    [DbContext(typeof(LaboratorioContexto))]
    [Migration("20190531015720_Exame")]
    partial class Exame
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LaboratorioArlissonMenacho.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("LaboratorioArlissonMenacho.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<int?>("PlanoDeSaudeId");

                    b.HasKey("Id");

                    b.HasIndex("PlanoDeSaudeId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("LaboratorioArlissonMenacho.Models.PlanoDeSaude", b =>
                {
                    b.Property<int>("PlanoDeSaudeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("PlanoDeSaudeId");

                    b.ToTable("Planos");
                });

            modelBuilder.Entity("LaboratorioArlissonMenacho.Models.Paciente", b =>
                {
                    b.HasOne("LaboratorioArlissonMenacho.Models.PlanoDeSaude", "PlanoDeSaude")
                        .WithMany()
                        .HasForeignKey("PlanoDeSaudeId");
                });
#pragma warning restore 612, 618
        }
    }
}
