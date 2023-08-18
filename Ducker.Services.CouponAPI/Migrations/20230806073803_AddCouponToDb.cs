using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ducker.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCouponToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CoupleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CouponDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CouponType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<double>(type: "float", nullable: false),
                    MinDiscount = table.Column<double>(type: "float", nullable: false),
                    MaxDiscount = table.Column<double>(type: "float", nullable: false),
                    CreateDts = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CoupleID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");
        }
    }
}
