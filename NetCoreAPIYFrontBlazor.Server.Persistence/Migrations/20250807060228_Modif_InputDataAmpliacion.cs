using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Modif_InputDataAmpliacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Altitude",
                table: "InputsData",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConectionHV1",
                table: "InputsData",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConectionLV1",
                table: "InputsData",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConectionVacio2",
                table: "InputsData",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "InputsData",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designer",
                table: "InputsData",
                type: "varchar(40)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Foils",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HVBIL",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HVKIND",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HVMAT",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KRAB",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KRBT",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LVBIL",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LVKIND",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LVMAT",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineVoltGuion",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineVoltHV1",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineVoltLV1",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineVoltVacio",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LineVoltVacio2",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Llosses",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NLLosses",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Noise",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiseKHi",
                table: "InputsData",
                type: "varchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiseKP",
                table: "InputsData",
                type: "varchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiseKSB",
                table: "InputsData",
                type: "varchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiseKV",
                table: "InputsData",
                type: "varchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OFNum",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rev",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SC",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Standard",
                table: "InputsData",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TMax",
                table: "InputsData",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurnsLV1",
                table: "InputsData",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "InputsData",
                type: "varchar(50)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altitude",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "ConectionHV1",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "ConectionLV1",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "ConectionVacio2",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Designer",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Foils",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "HVBIL",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "HVKIND",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "HVMAT",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "KRAB",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "KRBT",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LVBIL",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LVKIND",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LVMAT",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LineVoltGuion",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LineVoltHV1",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LineVoltLV1",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LineVoltVacio",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "LineVoltVacio2",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Llosses",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "NLLosses",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Noise",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "NoiseKHi",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "NoiseKP",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "NoiseKSB",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "NoiseKV",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "OFNum",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Rev",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "SC",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Standard",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "TMax",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "TurnsLV1",
                table: "InputsData");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "InputsData");
        }
    }
}
