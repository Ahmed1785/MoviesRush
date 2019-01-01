using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MoviesRush.Migrations
{
    public partial class ModifiedMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("INSERT INTO Movie (Id, Name, Genre, Stock) VALUES (1, 'Hangover', 'Comedy', 3)");
            migrationBuilder.Sql("INSERT INTO Movie (Id, Name, Genre, Stock) VALUES (2, 'Die Hard', 'Action', 5)");
            migrationBuilder.Sql("INSERT INTO Movie (Id, Name, Genre, Stock) VALUES (3, 'The Terminator', 'Action', 4)");
            migrationBuilder.Sql("INSERT INTO Movie (Id, Name, Genre, Stock) VALUES (4, 'Toy Story', 'Family', 2)");
            migrationBuilder.Sql("INSERT INTO Movie (Id, Name, Genre, Stock) VALUES (5, 'Titanic', 'Romance', 4)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Movie");
        }
    }
}
