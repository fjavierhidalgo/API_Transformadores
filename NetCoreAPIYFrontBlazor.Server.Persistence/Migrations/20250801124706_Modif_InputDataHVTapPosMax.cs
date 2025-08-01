using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Modif_InputDataHVTapPosMax : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HVTapPosMin",
                table: "InputsData",
                newName: "HVTapPosMax");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HVTapPosMax",
                table: "InputsData",
                newName: "HVTapPosMin");
        }
    }
}
