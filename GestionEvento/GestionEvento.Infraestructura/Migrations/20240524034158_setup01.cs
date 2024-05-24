using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionEvento.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class setup01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Evento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fecha_Evento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Desc_Evento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Num_Asistentes_Evento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "Desc_Evento", "Fecha_Evento", "Nom_Evento", "Num_Asistentes_Evento" },
                values: new object[,]
                {
                    { 1, "aaaaaaaaaaaaaaaaa", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parcial 01", 300 },
                    { 2, "eeeeeeeeeeeeeeeeeeeee", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parcial 02", 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
