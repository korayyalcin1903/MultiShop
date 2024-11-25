using Dapper;
using MultiShop.Discount.Context;
using MultiShop.Discount.Dtos;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MultiShop.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto)
        {
            string query = "insert into Coupons (Code, Rate, IsActive, ValidDate) values(@code, @rate, @isActive, @validDate)";
            var paramaters = new DynamicParameters();
            paramaters.Add("@code", createCouponDto.Code);
            paramaters.Add("@rate", createCouponDto.Rate);
            paramaters.Add("@isActive", createCouponDto.IsActive);
            paramaters.Add("@validDate", createCouponDto.ValidDate);
            using(var connections=_context.CreateConnection())
            {
                await connections.ExecuteAsync(query, paramaters);
            }
        }

        public async Task DeleteDiscountCouponAsync(int id)
        {
            string query = "Delete From Coupons where CouponId=@couponId";
            var paramaters = new DynamicParameters();
            paramaters.Add("couponId", id);
            using(var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, paramaters);
            }
        }

        public async Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync()
        {
            string query = "Select * from Coupons";
            using (var connection=_context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultDiscountCouponDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdDiscountCoupon> GetByIdDiscountCouponAsync(int id)
        {
            string query = "Select * from Coupons where CouponId=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection=_context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdDiscountCoupon>(query, parameters);
                return values;
            }
        }

        public async Task<ResultDiscountCouponDto> GetCodeDetailByCodeAsync(string code)
        {
            string query = "Select * from Coupons where Code=@code";
            var parameters = new DynamicParameters();
            parameters.Add("@code", code);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ResultDiscountCouponDto>(query, parameters);
                return values;
            }
        }

        public async Task<int> GetDiscountCouponCount()
        {
            string query = "Select Count(*) from Coupons";
            var parameters = new DynamicParameters();
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto)
        {
            string query = "Update Coupons Set Code=@code, Rate=@rate, IsActive=@isActive, ValidDate=@validDate where CouponId=@couponId";
            var paramaters = new DynamicParameters();
            paramaters.Add("@code", updateCouponDto.Code);
            paramaters.Add("@rate", updateCouponDto.Rate);
            paramaters.Add("@isActive", updateCouponDto.IsActive);
            paramaters.Add("@validDate", updateCouponDto.ValidDate);
            paramaters.Add("@couponId", updateCouponDto.CouponId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, paramaters);
            }
        }
    }
}
