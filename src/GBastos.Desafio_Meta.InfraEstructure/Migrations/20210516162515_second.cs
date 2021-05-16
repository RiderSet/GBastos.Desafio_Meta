using Microsoft.EntityFrameworkCore.Migrations;

namespace GBastos.Desafio_Meta.InfraEstructure.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmisAudiencia",
                table: "Audiencia");

            migrationBuilder.AddColumn<int>(
                name: "EmissoraId",
                table: "Audiencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Audiencia_EmissoraId",
                table: "Audiencia",
                column: "EmissoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiencia_Emissora_EmissoraId",
                table: "Audiencia",
                column: "EmissoraId",
                principalTable: "Emissora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audiencia_Emissora_EmissoraId",
                table: "Audiencia");

            migrationBuilder.DropIndex(
                name: "IX_Audiencia_EmissoraId",
                table: "Audiencia");

            migrationBuilder.DropColumn(
                name: "EmissoraId",
                table: "Audiencia");

            migrationBuilder.AddColumn<string>(
                name: "EmisAudiencia",
                table: "Audiencia",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
