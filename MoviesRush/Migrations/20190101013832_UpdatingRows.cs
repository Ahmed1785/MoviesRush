using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class UpdatingRows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (1, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (2, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (3, 'Drama')");
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (4, 'Suspense')");
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (5, 'Horror')");
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (6, 'Thriller')");
            migrationBuilder.Sql("INSERT INTO Genre (ID, Name) VALUES (7, 'Family')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
