using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPointProject.Data.Migrations
{
    public partial class RenamePersonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "People",
                newName: "Passport");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "People",
                newName: "MemberId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e513", "68e54136-1b97-478d-b9fc-ea61e9cda01f", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e513", 0, "0ae1c29d-2b3b-4918-8e63-7a4c926723cf", "Admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEJS7cNmLH5NT53btUgw3dFh4mj/fj45XqpF9tnkXuZ6qpk1aMachiLgfAGQmolTo3Q==", null, false, "", false, "Admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e513", "a18be9c0-aa65-4af8-bd17-00bd9344e513" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e513", "a18be9c0-aa65-4af8-bd17-00bd9344e513" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e513");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e513");

            migrationBuilder.RenameColumn(
                name: "Passport",
                table: "People",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "People",
                newName: "PersonId");
        }
    }
}
