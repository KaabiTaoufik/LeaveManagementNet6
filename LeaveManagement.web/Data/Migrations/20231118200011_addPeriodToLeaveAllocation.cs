using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addPeriodToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b20b4d78-e4bf-4cbd-9e1e-e2395464de28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "807d8bb2-9fc7-487c-a2ae-295d421342bf", "AQAAAAIAAYagAAAAEHSobi9IsIYFOhDB6Jsw7CxzaBXCiKiCVDgptjjCBaZ7fzhNdT7AcWxE/fQxGBjZ2w==", "7b155675-6ba1-40e2-b984-ae65a3bf5dec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2a475a0-482e-461e-876a-ad906172dfdb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15730aa1-1cb3-4ab0-a98b-5d0e0cf6362f", "AQAAAAIAAYagAAAAED1iqSItL61msUy0dIQZnzz4T+Ee3XDN/0Rk9Q0XHQ9yjcd5zNBcWtpkC1BZFgehPw==", "b6fb557c-81b5-49cf-a2f7-56737e4e9bc4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b20b4d78-e4bf-4cbd-9e1e-e2395464de28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee313f65-9ec5-49ed-82ee-49dff12a9e37", "AQAAAAIAAYagAAAAENt5Pb8M6YF1YZ65+RdtTicgl2gwaXXo2PGd5kB+dIKdZBPx0dxVQqfjNby7q3v/pg==", "e034be33-cce6-4d92-8c2e-6d107f4170f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2a475a0-482e-461e-876a-ad906172dfdb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3574c08c-4569-4b2d-96af-5c8128e306bf", "AQAAAAIAAYagAAAAEBPitiQ8bbZLm8sfgWX/n1UL3cIEeDv97U37ZnFJkHY2YjgAz9G8AQjPZ9FC2UHTiA==", "aa386360-96dc-40a3-af39-67964664292c" });
        }
    }
}
