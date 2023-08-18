using Ducker.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Ducker.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CoupleID = 1,
                CouponCode = "10code",
                CouponDescription= "Description",
                CouponName= "Name",
                CouponType= "Type",
                DiscountAmount = 10,
                MinDiscount = 20,
                MaxDiscount= 30,
            });
        }
    }
}
