using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3Security.Data.Migrations
{
    /// <inheritdoc />
    public partial class admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Age], [FirstName], [Gender], [LastName]) VALUES (N'bf7e977d-97f1-4c0f-92c6-18583d7ef88b', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAIAAYagAAAAEL3sgGO6v47IzFLiLBe7FOPTcVVVi+35ShDWcGcy21Jyr+bKnNQLVnqras/5FB3u0A==', N'DCG6RQ5PWKXRGRPRYDBKM5G4EQ5XP3SU', N'2788b584-f7b0-454b-a410-0f0792d18f75', NULL, 0, 0, NULL, 1, 0, N'40', N'Patrick', N'male', N'Stenmark')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetUsers] WHERE Id='bf7e977d-97f1-4c0f-92c6-18583d7ef88b'");

        }
    }
}
