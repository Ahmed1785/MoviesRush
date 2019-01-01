using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class UpdatedMovieAndGenreModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<byte>(
                name: "GenreId",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_GenreID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_GenreID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Movie",
                newName: "GenreID");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "Movie",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreID",
                table: "Movie",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_GenreID",
                table: "Movie",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
