﻿// <auto-generated />
using System;
using GestionEvento.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionEvento.Infraestructura.Migrations
{
    [DbContext(typeof(GestionEventoDbContext))]
    partial class GestionEventoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionEvento.Dominio.Entidades.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventoId"));

                    b.Property<string>("Desc_Evento")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Fecha_Evento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom_Evento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Num_Asistentes_Evento")
                        .HasColumnType("int");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");

                    b.HasData(
                        new
                        {
                            EventoId = 1,
                            Desc_Evento = "aaaaaaaaaaaaaaaaa",
                            Fecha_Evento = new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom_Evento = "Parcial 01",
                            Num_Asistentes_Evento = 300
                        },
                        new
                        {
                            EventoId = 2,
                            Desc_Evento = "eeeeeeeeeeeeeeeeeeeee",
                            Fecha_Evento = new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom_Evento = "Parcial 02",
                            Num_Asistentes_Evento = 150
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
