using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GastouderAdmin.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consulent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Achternaam = table.Column<string>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gastouders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Achternaam = table.Column<string>(nullable: true),
                    ConsulentId = table.Column<int>(nullable: true),
                    GoPlan = table.Column<bool>(nullable: false),
                    Huisnummer = table.Column<string>(nullable: true),
                    Huisregels = table.Column<bool>(nullable: false),
                    PedBeleid = table.Column<bool>(nullable: false),
                    PedWerkplan = table.Column<bool>(nullable: false),
                    Plaats = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Starttraject = table.Column<string>(nullable: true),
                    Straat = table.Column<string>(nullable: true),
                    Tink = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastouders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gastouders_Consulent_ConsulentId",
                        column: x => x.ConsulentId,
                        principalTable: "Consulent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gastouders_ConsulentId",
                table: "Gastouders",
                column: "ConsulentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gastouders");

            migrationBuilder.DropTable(
                name: "Consulent");
        }
    }
}
