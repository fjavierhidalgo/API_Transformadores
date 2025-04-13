using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntidadModificada = table.Column<string>(type: "TEXT", nullable: false),
                    EntidadModificadaId = table.Column<string>(type: "TEXT", nullable: false),
                    CampoModificado = table.Column<string>(type: "TEXT", nullable: false),
                    ValorAnterior = table.Column<string>(type: "TEXT", nullable: true),
                    ValorNuevo = table.Column<string>(type: "TEXT", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hechos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Anio = table.Column<int>(type: "INTEGER", nullable: false),
                    Detalle = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hechos", x => x.Id);
                });

            migrationBuilder.InsertData(                          
                          table: "Hechos",
                          columns: new[] { "Id", "Nombre","Anio","Detalle" },
                          values: new object[,]
                          {
                            { 1, "Guerra Independencia",1808,"" },
                            { 2, "Cortes de Cádiz, Constitución Liberal",1812,"" },
                            { 3, "Absolutismo Fernando VII",1814,"" },
                            { 4, "Trienio Liberal", 1820, "" },
                            { 5, "Absolutismo Fernando VII", 1823,"Década Ominosa" },
                            { 6, "I Guerra Carlista", 1833,"" },
                            { 7, "Regencia de Espartero",1835,"" },
                            { 8, "Gobierno Moderado Narváez",1843,"Fin de la Regencia" },
                            { 9, "Levantamiento Carlista",1848,"" },
                            { 10, "Bienio Progresista",1854,"" },
                            { 11, "Gobierno Moderado de O'Donell",1856,"" },
                            { 12, "Revolución Gloriosa",1868,"" },
                            { 13,"Reinado de Amadeo de Saboya",1870,""},
                            { 14, "I Republica",1873,"" },
                            { 15, "Gobierno de Serrano",1874,"Golpe de estado Gral. Pavía" },
                            { 16, "Restauración Borbónica, Alfonso XII",1875,"Canovas(Consevador), Sagasta(Liberal)" },
                            { 17, "Rey Alfonso XIII. Regencia de María Cristina",1885,"" },
                            { 18, "Pérdida de Cuba y Filipinas",1898,"" }
                          });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "Hechos");
        }
    }
}
