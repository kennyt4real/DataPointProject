using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPointProject.Data.Migrations
{
    public partial class AddedMoreFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e513",
                column: "ConcurrencyStamp",
                value: "59620c54-e86f-4c53-88cb-7931927e70ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e513",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "551ae871-a0a2-44ed-ba45-0d3499b8a6c7", "AQAAAAEAACcQAAAAEJe0FCfxNJNl1mMf2oBotGKc78AJX/Jo1gfCEMaNtljzYJtaHNgusBkNs3zllDZogg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Members");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e513",
                column: "ConcurrencyStamp",
                value: "b411d14a-5f81-46f4-8389-e192a3b73552");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e513",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e8342ff-997b-4994-a118-0f4515825c7f", "AQAAAAEAACcQAAAAEMQpap8w/SJ82JAr2VaL3q4CiEa9JeQMWbyUsgD9YaTtfBU8kaP8rVh20ZBRDaUUMA==" });
        }
    }
}
