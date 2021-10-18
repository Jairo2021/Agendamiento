﻿// <auto-generated />
using AgendaSIG5.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgendaSIG5.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211018165555_Azure2")]
    partial class Azure2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("AgendaSIG5.App.Dominio.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FK_Id_Medico")
                        .HasColumnType("int");

                    b.Property<int>("FK_Id_Paciente")
                        .HasColumnType("int");

                    b.Property<int>("FK_Id_Sede")
                        .HasColumnType("int");

                    b.Property<string>("FechaCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AgendaCitas");
                });

            modelBuilder.Entity("AgendaSIG5.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreCiudad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("AgendaSIG5.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ECorreo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_Id_Sede")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefonos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("AgendaSIG5.App.Dominio.Sede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FK_Id_Ciudad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sedes");
                });
#pragma warning restore 612, 618
        }
    }
}
