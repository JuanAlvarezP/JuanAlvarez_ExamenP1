﻿// <auto-generated />
using JuanAlvarez_ExamenP1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuanAlvarez_ExamenP1.Migrations
{
    [DbContext(typeof(JuanAlvarez_ExamenP1Context))]
    [Migration("20231025130037_Cambios")]
    partial class Cambios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JuanAlvarez_ExamenP1.Models.JuanAlvarez_tabla", b =>
                {
                    b.Property<string>("jaCedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("jaAñosEmpresa")
                        .HasColumnType("bit");

                    b.Property<string>("jaCorreo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("jaEdad")
                        .HasColumnType("int");

                    b.Property<int>("jaNacimiento")
                        .HasColumnType("int");

                    b.Property<string>("jaNombre")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("jaSalario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("jaCedula");

                    b.ToTable("JuanAlvarez_tabla");
                });
#pragma warning restore 612, 618
        }
    }
}
