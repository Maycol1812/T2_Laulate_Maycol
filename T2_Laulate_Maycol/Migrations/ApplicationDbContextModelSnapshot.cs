﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T2_Laulate_Maycol.Datos;

#nullable disable

namespace T2_Laulate_Maycol.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("T2_Laulate_Maycol.Models.Distribuidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnioInicioOperacion")
                        .HasColumnType("int");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDistribuidor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Distribuidor");
                });

            modelBuilder.Entity("T2_Laulate_Maycol.Models.DistribuidorMundo", b =>
                {
                    b.Property<int>("IdMundo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMundo"));

                    b.Property<int>("AnioInicioOperacionMundo")
                        .HasColumnType("int");

                    b.Property<string>("ContactoMundo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDistribuidorMundo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocialMundo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonoMundo")
                        .HasColumnType("int");

                    b.HasKey("IdMundo");

                    b.ToTable("DistribuidorMUNDO");
                });

            modelBuilder.Entity("T2_Laulate_Maycol.Models.DistribuidorPeru", b =>
                {
                    b.Property<int>("IdPeru")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPeru"));

                    b.Property<int>("AnioInicioOperacionPeru")
                        .HasColumnType("int");

                    b.Property<string>("ContactoPeru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDistribuidorPeru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocialPeru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonoPeru")
                        .HasColumnType("int");

                    b.HasKey("IdPeru");

                    b.ToTable("DistribuidorPE");
                });
#pragma warning restore 612, 618
        }
    }
}
