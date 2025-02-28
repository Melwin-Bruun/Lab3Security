using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3Security.Data.Migrations
{
    /// <inheritdoc />
    public partial class adminsetroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [AspNetUserRoles] (UserId,RoleId) SELECT 'bf7e977d-97f1-4c0f-92c6-18583d7ef88b', Id FROM [AspNetRoles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetUserRoles] WHERE UserId='bf7e977d-97f1-4c0f-92c6-18583d7ef88b'");
        }
    }
}
