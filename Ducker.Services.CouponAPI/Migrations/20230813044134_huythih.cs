using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ducker.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class huythih : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CouponType",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CouponDescription",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CoupleID",
                keyValue: 1,
                column: "CreateDts",
                value: new DateTime(2023, 8, 13, 11, 41, 34, 151, DateTimeKind.Local).AddTicks(1653));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CouponType",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CouponDescription",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CoupleID",
                keyValue: 1,
                column: "CreateDts",
                value: new DateTime(2023, 8, 6, 14, 49, 26, 473, DateTimeKind.Local).AddTicks(6017));
        }
    }
}
