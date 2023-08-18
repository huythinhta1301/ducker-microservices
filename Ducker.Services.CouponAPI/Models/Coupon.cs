using System.ComponentModel.DataAnnotations;

namespace Ducker.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        [Required]
        public int CoupleID { get; set; }
        [Required]
        public string CouponName { get;set; }
        [Required]
        public string CouponCode { get;set; }
        public string? CouponDescription { get;set; }
        public string? CouponType { get;set; }
        public double DiscountAmount { get; set; } = 1;
        public double MinDiscount { get; set; } = 10;
        public double MaxDiscount { get; set; } = 20;
        public DateTime CreateDts { get; set; } = DateTime.Now;
        public int Status { get; set; } = 0;

    }
}
