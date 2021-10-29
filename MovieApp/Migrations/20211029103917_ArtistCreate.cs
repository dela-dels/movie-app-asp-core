using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class ArtistCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    First_Name = table.Column<string>(type: "TEXT", nullable: true),
                    Last_Name = table.Column<string>(type: "TEXT", nullable: true),
                    Other_Names = table.Column<string>(type: "TEXT", nullable: true),
                    Cast_Name = table.Column<string>(type: "TEXT", nullable: true),
                    Date_of_Birth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");
        }
    }
}
