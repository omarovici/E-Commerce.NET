using Store.Service.Services.BasketService.Dtos;
using Store.Service.Services.OrderService.Dtos;

namespace Store.Service.Services.PaymentService;

public interface IPaymentService
{
    Task<CustomerBasketDto> CreateOrUpdatePaymentIntent(CustomerBasketDto basket);
    Task<OrderDetailsDto> UpdateOrderPaymentSucceeded(string paymentIntentId);
    Task<OrderDetailsDto> UpdateOrderPaymentFailed(string paymentIntentId);
}