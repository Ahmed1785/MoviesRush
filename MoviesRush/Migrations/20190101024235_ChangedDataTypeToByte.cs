using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class ChangedDataTypeToByte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {




            migrationBuilder.AlterColumn<byte>(
                name: "ID",
                table: "Genre",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySQL:AutoIncrement", true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Movie",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Genre",
                nullable: false,
                oldClrType: typeof(byte))
                .Annotation("MySQL:AutoIncrement", true);

        }
    }
}
