using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class RemovedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscribedToNewsletter",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "IsSubscribedToNewsletter",
                table: "Customer",
                nullable: true);
        }
    }
}
