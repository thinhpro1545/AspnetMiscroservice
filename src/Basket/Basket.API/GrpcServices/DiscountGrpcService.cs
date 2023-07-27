using Discount.Grpc.Protos;
using System;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService ?? throw new ArgumentNullException(nameof(discountProtoService));
        }
        public async Task<CouponModel> GetDiscount(string productname)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productname};

            return await _discountProtoService.GetDiscountAsync(discountRequest); ;
        }
    }
}
