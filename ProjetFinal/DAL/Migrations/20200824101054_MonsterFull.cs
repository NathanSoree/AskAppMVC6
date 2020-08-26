using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MonsterFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Monsters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LairAction",
                table: "Monsters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegEffects",
                table: "Monsters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "LairAction",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "RegEffects",
                table: "Monsters");
        }
    }
}
