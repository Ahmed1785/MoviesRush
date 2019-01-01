using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRush.Migrations
{
    public partial class UpdatedMembershipTypeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update MembershipType SET Name = 'Quarterly' Where ID = 3");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Yearly' Where ID = 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
