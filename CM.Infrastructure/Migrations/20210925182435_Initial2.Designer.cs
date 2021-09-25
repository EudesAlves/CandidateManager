﻿// <auto-generated />
using System;
using CM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CM.Infrastructure.Migrations
{
    [DbContext(typeof(CMContext))]
    [Migration("20210925182435_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CM.Domain.Entity.Candidato", b =>
                {
                    b.Property<int>("CandidatoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarteiraTrabalho")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CarteiraTrabalhoSerie")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CarteiraTrabalhoUf")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rg")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("CandidatoId");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("CM.Domain.Entity.CandidatoHabilidade", b =>
                {
                    b.Property<int>("CandidadoHabilidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatoId");

                    b.Property<int>("HabilidadeId");

                    b.HasKey("CandidadoHabilidadeId");

                    b.HasIndex("CandidatoId");

                    b.HasIndex("HabilidadeId");

                    b.ToTable("CandidatoHabilidade");
                });

            modelBuilder.Entity("CM.Domain.Entity.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatoId");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(400)");

                    b.Property<string>("LinkedinLink")
                        .HasColumnType("varchar(400)");

                    b.Property<string>("RedeSocial")
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(30)");

                    b.HasKey("ContatoId");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("CM.Domain.Entity.Habilidade", b =>
                {
                    b.Property<int>("HabilidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Tag")
                        .HasColumnType("varchar(100)");

                    b.HasKey("HabilidadeId");

                    b.ToTable("Habilidade");
                });

            modelBuilder.Entity("CM.Domain.Entity.CandidatoHabilidade", b =>
                {
                    b.HasOne("CM.Domain.Entity.Candidato", "Candidato")
                        .WithMany("CandidatoHabilidades")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CM.Domain.Entity.Habilidade", "Habilidade")
                        .WithMany("CandidatoHabilidades")
                        .HasForeignKey("HabilidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CM.Domain.Entity.Contato", b =>
                {
                    b.HasOne("CM.Domain.Entity.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
