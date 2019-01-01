using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class PopulateCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Customer (ID, ConfirmPassword, Email, FirstName, LastName, MembershipTypeId, Password) VALUES (1, 'tester', 'test@test.com', 'user', 'name', 1, 'tester')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE Customer DROP COLUMN IsSubscribedNewsletter");
        }
    }
}
