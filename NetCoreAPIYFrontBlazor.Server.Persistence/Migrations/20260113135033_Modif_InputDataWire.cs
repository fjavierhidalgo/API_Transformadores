using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Modif_InputDataWire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Wire",
                table: "InputsData",
                type: "varchar(5)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wire",
                table: "InputsData");
        }
    }
}
