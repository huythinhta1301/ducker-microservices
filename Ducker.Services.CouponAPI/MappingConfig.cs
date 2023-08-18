using AutoMapper;
using Ducker.Services.CouponAPI.Models;
using Ducker.Services.CouponAPI.Models.DTO;

namespace Ducker.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDTO, Coupon>();
                config.CreateMap<Coupon, CouponDTO>();
            });
            return mappingConfig;
        }

    }
}
