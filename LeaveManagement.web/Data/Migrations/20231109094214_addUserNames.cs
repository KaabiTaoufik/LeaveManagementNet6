using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addUserNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b20b4d78-e4bf-4cbd-9e1e-e2395464de28",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ee313f65-9ec5-49ed-82ee-49dff12a9e37", true, "USER@TEST.COM", "AQAAAAIAAYagAAAAENt5Pb8M6YF1YZ65+RdtTicgl2gwaXXo2PGd5kB+dIKdZBPx0dxVQqfjNby7q3v/pg==", "e034be33-cce6-4d92-8c2e-6d107f4170f8", "user@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2a475a0-482e-461e-876a-ad906172dfdb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3574c08c-4569-4b2d-96af-5c8128e306bf", true, "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEBPitiQ8bbZLm8sfgWX/n1UL3cIEeDv97U37ZnFJkHY2YjgAz9G8AQjPZ9FC2UHTiA==", "aa386360-96dc-40a3-af39-67964664292c", "admin@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b20b4d78-e4bf-4cbd-9e1e-e2395464de28",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "560115df-67ae-493d-8fe2-bc2f837383f8", false, null, "AQAAAAIAAYagAAAAENhiTPiCnvrI/0b03RfpF/YaS5ql8wpm8kQQr+GXYWpkQOroUuj8mZ27pumoDoNjqA==", "1eaa5e4f-10cc-43f1-84c8-7ab2c84c7505", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2a475a0-482e-461e-876a-ad906172dfdb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0462fd0d-1445-4d16-b3e8-7cbe76b0af07", false, null, "AQAAAAIAAYagAAAAEJHyivR9okQ7dDAmf6yjtdgFpB3CUtGEW6VQYAJSK6Ciwi0kwJ8y0bB1w82wLWeZpg==", "097276e9-4d70-4ea8-80a8-41343a6f53c5", null });
        }
    }
}
