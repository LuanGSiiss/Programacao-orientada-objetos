﻿// <auto-generated />
using ConFinServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConFinServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250314001711_Cidade")]
    partial class Cidade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConFinServer.Model.Cidade", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Codigo"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ConFinServer.Model.Estado", b =>
                {
                    b.Property<string>("Sigla")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Sigla");

                    b.ToTable("Estado");
                });
#pragma warning restore 612, 618
        }
    }
}
