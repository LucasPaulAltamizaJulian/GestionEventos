using GestionEvento.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEvento.Infraestructura.Data
{
    public class GestionEventoDbContext : DbContext
    {
        public GestionEventoDbContext(DbContextOptions<GestionEventoDbContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Evento>().HasData(
                new Evento
                {
                    EventoId = 1,
                    Nom_Evento = "Parcial 01",
                    Fecha_Evento = new DateTime(2024, 6, 15),
                    Desc_Evento = "aaaaaaaaaaaaaaaaa",
                    Num_Asistentes_Evento = 300
                },
                new Evento
                {
                    EventoId = 2,
                    Nom_Evento = "Parcial 02",
                    Fecha_Evento = new DateTime(2024, 7, 20),
                    Desc_Evento = "eeeeeeeeeeeeeeeeeeeee",
                    Num_Asistentes_Evento = 150
                }
            );
        }
    }
}
