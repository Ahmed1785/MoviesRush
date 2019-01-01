using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class AddedNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipType",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.Sql("Update MembershipType SET Name = 'Pay as You Go' Where ID = 1");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Monthly' Where ID = 2");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Quarterly' Where ID = 3");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Yearly' Where ID = 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");
        }
    }
}
