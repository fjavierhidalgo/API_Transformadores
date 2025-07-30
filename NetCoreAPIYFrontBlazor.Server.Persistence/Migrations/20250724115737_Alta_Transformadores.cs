using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Alta_Transformadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
     

            migrationBuilder.CreateTable(
                name: "Transformadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "varchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Referencia = table.Column<string>(type: "varchar(40)", fixedLength: true, maxLength: 40, nullable: true),
                    Detalle = table.Column<string>(type: "varchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transformadores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transformadores");

  
        }
    }
}
