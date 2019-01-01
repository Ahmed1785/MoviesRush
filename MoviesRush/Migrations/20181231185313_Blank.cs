using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class Blank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, Email, Password, ConfirmPassword, Birthday, MembershipTypeId, IsSubscribedToNewsletter) VALUES ('John', 'Snow', 'johnsnow@test.com', 'tester', 'tester', Null, 1, True)");
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, Email, Password, ConfirmPassword, Birthday, MembershipTypeId, IsSubscribedToNewsletter) VALUES ('Billy', 'Bob', 'billybob@test.com', 'tester', 'tester', Null, 1, False)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
