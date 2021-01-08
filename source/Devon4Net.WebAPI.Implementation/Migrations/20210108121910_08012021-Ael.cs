using Microsoft.EntityFrameworkCore.Migrations;

namespace Devon4Net.WebAPI.Implementation.Migrations
{
    public partial class _08012021Ael : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Town_UserId",
                table: "User_Town");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "User_Town",
                type: "character varying",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_Town_UserId",
                table: "User_Town",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Town_UserId",
                table: "User_Town");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "User_Town");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Users",
                type: "character varying",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_Town_UserId",
                table: "User_Town",
                column: "UserId");
        }
    }
}
