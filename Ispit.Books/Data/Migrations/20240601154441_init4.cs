using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ispit.Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "008440b9-3383-4927-b4cf-4777201ba608", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f980d135-2ad3-499c-b091-e2d43c9d27d1", 0, "abe3dc29-1a1c-4000-96b3-60053e85da86", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEG9TMZWfNo3B4RCWCapxLu8iNzfha7SPNDryQhHklv+hn9IQExhoHc0z5ZEEE3PmrQ==", null, false, "813e825f-33d1-4fc4-a1cc-2f8bc2517416", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "008440b9-3383-4927-b4cf-4777201ba608", "f980d135-2ad3-499c-b091-e2d43c9d27d1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "008440b9-3383-4927-b4cf-4777201ba608", "f980d135-2ad3-499c-b091-e2d43c9d27d1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "008440b9-3383-4927-b4cf-4777201ba608");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f980d135-2ad3-499c-b091-e2d43c9d27d1");

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
    }
}
