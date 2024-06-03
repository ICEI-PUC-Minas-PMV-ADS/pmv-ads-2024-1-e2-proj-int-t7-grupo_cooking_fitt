﻿// <auto-generated />
using System;
using CookingFit_backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookingFit_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240603140827_AtualizacaoCardapio")]
    partial class AtualizacaoCardapio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CardapioIngrediente", b =>
                {
                    b.Property<int>("CardapioId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientesAssociadosId")
                        .HasColumnType("int");

                    b.HasKey("CardapioId", "IngredientesAssociadosId");

                    b.HasIndex("IngredientesAssociadosId");

                    b.ToTable("CardapioIngrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Cardapio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cardapio");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Informacao", b =>
                {
                    b.Property<int>("IdInfo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInfo"), 1L, 1);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormAcademica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInfo");

                    b.ToTable("InfoUser");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoIngredienteId")
                        .HasColumnType("int");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TipoIngredienteId");

                    b.ToTable("Ingrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ingrediente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("CookingFit_backend.Models.TipoIngrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoIngrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CardapioIngrediente", b =>
                {
                    b.HasOne("CookingFit_backend.Models.Cardapio", null)
                        .WithMany()
                        .HasForeignKey("CardapioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookingFit_backend.Models.Ingrediente", null)
                        .WithMany()
                        .HasForeignKey("IngredientesAssociadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CookingFit_backend.Models.Cardapio", b =>
                {
                    b.HasOne("CookingFit_backend.Models.Usuario", "Usuario")
                        .WithMany("Cardapio")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Ingrediente", b =>
                {
                    b.HasOne("CookingFit_backend.Models.TipoIngrediente", "TipoIngrediente")
                        .WithMany("Ingrediente")
                        .HasForeignKey("TipoIngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoIngrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.TipoIngrediente", b =>
                {
                    b.Navigation("Ingrediente");
                });

            modelBuilder.Entity("CookingFit_backend.Models.Usuario", b =>
                {
                    b.Navigation("Cardapio");
                });
#pragma warning restore 612, 618
        }
    }
}
