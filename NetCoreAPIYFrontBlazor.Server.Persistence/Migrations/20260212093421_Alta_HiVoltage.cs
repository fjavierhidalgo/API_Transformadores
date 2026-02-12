using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Alta_HiVoltage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wire",
                table: "InputsData");

            migrationBuilder.CreateTable(
                name: "HiVoltages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransformadorId = table.Column<int>(type: "INTEGER", nullable: true),
                    Wire = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    StripSizeMin = table.Column<int>(type: "int", nullable: true),
                    StripSizeMax = table.Column<int>(type: "int", nullable: true),
                    ParallCondGrossWireMin = table.Column<int>(type: "int", nullable: true),
                    ParallCondGrossWireMax = table.Column<int>(type: "int", nullable: true),
                    NudeCondGrossWire = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    NudeCond = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    ParallCondMin = table.Column<int>(type: "int", nullable: true),
                    ParallCondMax = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiVoltages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HiVoltages_Transformadores_TransformadorId",
                        column: x => x.TransformadorId,
                        principalTable: "Transformadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HiVoltages_TransformadorId",
                table: "HiVoltages",
                column: "TransformadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HiVoltages");

            migrationBuilder.AddColumn<string>(
                name: "Wire",
                table: "InputsData",
                type: "varchar(5)",
                nullable: true);
        }
    }
}
