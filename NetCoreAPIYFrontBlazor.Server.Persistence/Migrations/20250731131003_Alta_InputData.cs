using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Alta_InputData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hechos");

            migrationBuilder.CreateTable(
                name: "InputsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransformadorId = table.Column<int>(type: "INTEGER", nullable: true),
                    Project = table.Column<string>(type: "varchar(30)", nullable: true),
                    Customer = table.Column<string>(type: "varchar(30)", nullable: true),
                    Power = table.Column<int>(type: "INTEGER", nullable: true),
                    Frecc = table.Column<int>(type: "INTEGER", nullable: true),
                    Cooling = table.Column<string>(type: "varchar(10)", nullable: true),
                    HVTapNegNumero = table.Column<decimal>(type: "TEXT", nullable: true),
                    HVTapNegRegulacion = table.Column<decimal>(type: "TEXT", nullable: true),
                    HVTapNegMin = table.Column<decimal>(type: "TEXT", nullable: true),
                    HVTapPosNumero = table.Column<decimal>(type: "TEXT", nullable: true),
                    HVTapPosRegulacion = table.Column<decimal>(type: "TEXT", nullable: true),
                    HVTapPosMin = table.Column<decimal>(type: "TEXT", nullable: true),
                    OilKind = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InputsData_Transformadores_TransformadorId",
                        column: x => x.TransformadorId,
                        principalTable: "Transformadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InputsData_TransformadorId",
                table: "InputsData",
                column: "TransformadorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputsData");

            migrationBuilder.CreateTable(
                name: "Hechos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Anio = table.Column<int>(type: "INTEGER", nullable: true),
                    Detalle = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hechos", x => x.Id);
                });
        }
    }
}
