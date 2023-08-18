using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ducker.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class addStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CoupleID",
                keyValue: 1,
                columns: new[] { "CreateDts", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 11, 49, 31, 627, DateTimeKind.Local).AddTicks(2234), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Coupons");

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CoupleID",
                keyValue: 1,
                column: "CreateDts",
                value: new DateTime(2023, 8, 13, 11, 41, 34, 151, DateTimeKind.Local).AddTicks(1653));
        }
    }
}
