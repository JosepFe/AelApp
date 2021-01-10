using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Devon4Net.WebAPI.Implementation.Migrations
{
    public partial class Ael10012021InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TaxName = table.Column<string>(type: "character varying", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    TaxDeadlineDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TownName = table.Column<string>(type: "character varying", nullable: false),
                    Community = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying", nullable: false),
                    Surname = table.Column<string>(type: "character varying", nullable: false),
                    DNI = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Tax",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TaxId = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "date", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    Paid = table.Column<bool>(type: "boolean", nullable: false),
                    BaseAmount = table.Column<int>(type: "integer", nullable: false),
                    PaymentDeadlineDate = table.Column<DateTime>(type: "date", nullable: true),
                    AmountToPay = table.Column<int>(type: "integer", nullable: true),
                    Reference = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Tax", x => x.Id);
                    table.ForeignKey(
                        name: "user_tax_fk",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "user_tax_fk_1",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Town",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TownId = table.Column<Guid>(type: "uuid", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "date", nullable: false),
                    Adress = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Town", x => x.Id);
                    table.ForeignKey(
                        name: "user_town_fk",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "user_town_fk_1",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Tax_TaxId",
                table: "User_Tax",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Tax_UserId",
                table: "User_Tax",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Town_TownId",
                table: "User_Town",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Town_UserId",
                table: "User_Town",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Tax");

            migrationBuilder.DropTable(
                name: "User_Town");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
