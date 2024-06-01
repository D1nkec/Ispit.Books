using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ispit.Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6dfb7b32-4d8b-4288-ae55-056164760c8a", "e71a6e64-8375-45c3-9b1b-70961979ae52" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dfb7b32-4d8b-4288-ae55-056164760c8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71a6e64-8375-45c3-9b1b-70961979ae52");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "174bb72a-899f-4281-8d66-aecdff04df4d", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e17e7050-f664-46a6-a882-0ff4d51e703a", 0, "b85e3a33-1eab-4899-a0b4-c8a3f0b4e713", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJTBy3tI7Ffm9ffUzbhGlaz2qleqA+PZrLksRIzPuQxlpndxRMJtPS1sAMlH9ihMTw==", null, false, "f0d0f030-0b57-46c3-ac09-f16357ac5894", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "174bb72a-899f-4281-8d66-aecdff04df4d", "e17e7050-f664-46a6-a882-0ff4d51e703a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "174bb72a-899f-4281-8d66-aecdff04df4d", "e17e7050-f664-46a6-a882-0ff4d51e703a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "174bb72a-899f-4281-8d66-aecdff04df4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e17e7050-f664-46a6-a882-0ff4d51e703a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6dfb7b32-4d8b-4288-ae55-056164760c8a", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e71a6e64-8375-45c3-9b1b-70961979ae52", 0, "f873be31-1b9c-468b-a55e-79d7752318fc", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENahWpsboCrv6R7v1urhPw7h5pY7vNIVRVN3MBUCKIhIVYegZblNFuoC4IX0VQUvEw==", null, false, "1a90c402-0b92-47a6-958b-d973664811dc", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6dfb7b32-4d8b-4288-ae55-056164760c8a", "e71a6e64-8375-45c3-9b1b-70961979ae52" });
        }
    }
}
