using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ducker.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class addDataCoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CoupleID", "CouponCode", "CouponDescription", "CouponName", "CouponType", "CreateDts", "DiscountAmount", "MaxDiscount", "MinDiscount" },
                values: new object[] { 1, "10code", "Description", "Name", "Type", new DateTime(2023, 8, 6, 14, 49, 26, 473, DateTimeKind.Local).AddTicks(6017), 10.0, 30.0, 20.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CoupleID",
                keyValue: 1);
        }
    }
}
