using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Apple_Dolls.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doll",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 45, nullable: true),
                    Material = table.Column<string>(maxLength: 30, nullable: true),
                    Doll_Height = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    SetTheme = table.Column<string>(maxLength: 20, nullable: true),
                    AgeGroup = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doll", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doll");
        }
    }
}
