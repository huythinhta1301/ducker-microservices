using AutoMapper;
using Ducker.Services.CouponAPI.Data;
using Ducker.Services.CouponAPI.Models;
using Ducker.Services.CouponAPI.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ducker.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDTO _res;
        private IMapper _mapper;
        public CouponAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _res = new ResponseDTO();
        }

        [HttpGet]
        public ResponseDTO Get()
        {
            try
            {
                IEnumerable<Coupon> objCouponList = _db.Coupons.ToList();
                _res.Data = _mapper.Map<IEnumerable<Coupon>>(objCouponList);
            }
            catch (Exception ex) 
            {
                _res.IsSuccess = false;
                _res.Message = ex.Message;
            }
            return _res;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO GetByID(int id)
        {
            try
            {
                Coupon objCouponList = _db.Coupons.First(c => c.CoupleID == id);
                _res.Data = _mapper.Map<Coupon>(objCouponList);
                if(objCouponList == null) 
                {
                    _res.Message = $"Cannot find ID {id} in system";
                }
                
            }
            catch (Exception ex) 
            {
                _res.IsSuccess = false;
                _res.Message = ex.Message;
            }
            return _res;
        }

        [HttpGet]
        [Route("code")]
        public ResponseDTO GetByCode(string code)
        {
            try
            {
                Coupon objCouponList = _db.Coupons.FirstOrDefault(c => c.CouponCode.ToLower().Contains(code.ToLower()));
                _res.Data = _mapper.Map<Coupon>(objCouponList);
                if (objCouponList == null)
                {
                    _res.Message = $"Cannot find Code {code} in system";
                }
            }
            catch (Exception ex)
            {
                _res.IsSuccess = false;
                _res.Message = ex.Message;
            }
            return _res;
        }

        [HttpPost]
        public ResponseDTO NEW([FromBody] CouponDTO cpDto)
        {
            try
            {
                Coupon coup = _mapper.Map<Coupon>(cpDto);
                _db.Coupons.Add(coup);
                _db.SaveChanges();

                _res.Data = _mapper.Map<Coupon>(coup);
            }
            catch (Exception ex)
            {
                _res.IsSuccess = false;
                _res.Message = ex.Message;
            }
            return _res;
        }

        [HttpDelete]
        public ResponseDTO DELETE(int id)
        {
            try
            {
                Coupon coup = _db.Coupons.First(c => c.CoupleID == id);
                _db.Coupons.Remove(coup);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _res.IsSuccess = false;
                _res.Message = ex.Message;
            }
            return _res;
        }
    }
}
