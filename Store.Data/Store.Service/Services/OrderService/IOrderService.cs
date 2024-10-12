using Store.Data.Entities;
using Store.Service.Services.OrderService.Dtos;

namespace Store.Service.Services.OrderService;

public interface IOrderService
{
    Task<OrderDetailsDto> CreateOrderAsync(OrderDto input);
    Task<IReadOnlyList<OrderDetailsDto>> GetOrdersForUserAsync(string buyerEmail);
    Task<OrderDetailsDto> GetOrderByIdAsync(Guid id);
    Task<IReadOnlyList<OrderDetailsDto>> GetAllDeliveryMethodsAsync();
}