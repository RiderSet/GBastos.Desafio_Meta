using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBastos.Desafio_Meta.InfraEstructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audiencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PtsAudiencia = table.Column<long>(type: "bigint", nullable: false),
                    DtHrAudiencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmisAudiencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audiencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emissora",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emissora", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audiencia");

            migrationBuilder.DropTable(
                name: "Emissora");
        }
    }
}
