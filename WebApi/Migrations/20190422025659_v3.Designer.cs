﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebApi.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20190422025659_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Infra.Entidades.ArquivoBase", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("IndexID");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("IndexID");

                    b.ToTable("ArquivoBase");
                });

            modelBuilder.Entity("Infra.Entidades.Cabecalho", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ArquivoBaseID");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ArquivoBaseID");

                    b.ToTable("Cabecalho");
                });

            modelBuilder.Entity("Infra.Entidades.Index", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Indice");
                });

            modelBuilder.Entity("Infra.Entidades.LinhaPedidoImportacao", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ArquivoBaseID");

                    b.Property<string>("EstaFeito");

                    b.Property<long?>("PedidoImportacaoID");

                    b.HasKey("ID");

                    b.HasIndex("ArquivoBaseID");

                    b.HasIndex("PedidoImportacaoID");

                    b.ToTable("LinhaPedidoImportacao");
                });

            modelBuilder.Entity("Infra.Entidades.PedidoImportacao", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataTermino");

                    b.Property<long?>("UsuarioMatricula");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioMatricula");

                    b.ToTable("PedidoImportacao");
                });

            modelBuilder.Entity("Infra.Entidades.Usuario", b =>
                {
                    b.Property<long>("Matricula")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("SobreNome")
                        .IsRequired();

                    b.Property<long?>("UsuarioMatricula");

                    b.HasKey("Matricula");

                    b.HasIndex("UsuarioMatricula");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Infra.Entidades.ArquivoBase", b =>
                {
                    b.HasOne("Infra.Entidades.Index", "Index")
                        .WithMany("ArquivoBases")
                        .HasForeignKey("IndexID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infra.Entidades.Cabecalho", b =>
                {
                    b.HasOne("Infra.Entidades.ArquivoBase", "ArquivoBase")
                        .WithMany("Cabecalhos")
                        .HasForeignKey("ArquivoBaseID");
                });

            modelBuilder.Entity("Infra.Entidades.LinhaPedidoImportacao", b =>
                {
                    b.HasOne("Infra.Entidades.ArquivoBase", "ArquivoBase")
                        .WithMany()
                        .HasForeignKey("ArquivoBaseID");

                    b.HasOne("Infra.Entidades.PedidoImportacao", "PedidoImportacao")
                        .WithMany()
                        .HasForeignKey("PedidoImportacaoID");
                });

            modelBuilder.Entity("Infra.Entidades.PedidoImportacao", b =>
                {
                    b.HasOne("Infra.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioMatricula");
                });

            modelBuilder.Entity("Infra.Entidades.Usuario", b =>
                {
                    b.HasOne("Infra.Entidades.Usuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioMatricula");
                });
#pragma warning restore 612, 618
        }
    }
}
