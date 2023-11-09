using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53d14e40-8320-4bea-9bfd-ca3f40a55bc4", null, "User", "USER" },
                    { "ebe6352a-a838-44a6-a1d8-a8daaaa5bb50", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b20b4d78-e4bf-4cbd-9e1e-e2395464de28", 0, "560115df-67ae-493d-8fe2-bc2f837383f8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "Sys", "User", false, null, "USER@TEST.COM", null, "AQAAAAIAAYagAAAAENhiTPiCnvrI/0b03RfpF/YaS5ql8wpm8kQQr+GXYWpkQOroUuj8mZ27pumoDoNjqA==", null, false, "1eaa5e4f-10cc-43f1-84c8-7ab2c84c7505", null, false, null },
                    { "d2a475a0-482e-461e-876a-ad906172dfdb", 0, "0462fd0d-1445-4d16-b3e8-7cbe76b0af07", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "Sys", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAIAAYagAAAAEJHyivR9okQ7dDAmf6yjtdgFpB3CUtGEW6VQYAJSK6Ciwi0kwJ8y0bB1w82wLWeZpg==", null, false, "097276e9-4d70-4ea8-80a8-41343a6f53c5", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "53d14e40-8320-4bea-9bfd-ca3f40a55bc4", "b20b4d78-e4bf-4cbd-9e1e-e2395464de28" },
                    { "ebe6352a-a838-44a6-a1d8-a8daaaa5bb50", "d2a475a0-482e-461e-876a-ad906172dfdb" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53d14e40-8320-4bea-9bfd-ca3f40a55bc4", "b20b4d78-e4bf-4cbd-9e1e-e2395464de28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebe6352a-a838-44a6-a1d8-a8daaaa5bb50", "d2a475a0-482e-461e-876a-ad906172dfdb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53d14e40-8320-4bea-9bfd-ca3f40a55bc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe6352a-a838-44a6-a1d8-a8daaaa5bb50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b20b4d78-e4bf-4cbd-9e1e-e2395464de28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2a475a0-482e-461e-876a-ad906172dfdb");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
