using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace cryptinopAPI.Migrations
{
    public partial class CompleterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valeur",
                table: "Monnaies");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Monnaies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Monnaies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValMonnaies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rang = table.Column<int>(nullable: false),
                    Valeur = table.Column<decimal>(nullable: false),
                    Variation1H = table.Column<double>(nullable: false),
                    Variation24H = table.Column<double>(nullable: false),
                    Variation7Jrs = table.Column<double>(nullable: false),
                    Volume24H = table.Column<decimal>(nullable: false),
                    CapMarche = table.Column<decimal>(nullable: false),
                    DateDernMAJ = table.Column<DateTime>(nullable: false),
                    MonnaieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValMonnaies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValMonnaies_Monnaies_MonnaieId",
                        column: x => x.MonnaieId,
                        principalTable: "Monnaies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategorieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_Categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monnaies_TypeId",
                table: "Monnaies",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_CategorieId",
                table: "Types",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_ValMonnaies_MonnaieId",
                table: "ValMonnaies",
                column: "MonnaieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Monnaies_Types_TypeId",
                table: "Monnaies",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monnaies_Types_TypeId",
                table: "Monnaies");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "ValMonnaies");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Monnaies_TypeId",
                table: "Monnaies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Monnaies");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Monnaies");

            migrationBuilder.AddColumn<string>(
                name: "Valeur",
                table: "Monnaies",
                type: "text",
                nullable: true);
        }
    }
}
