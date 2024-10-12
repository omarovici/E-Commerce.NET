using Store.Service.Services.OrderService.Dtos;

namespace Store.Service.Services.OrderService;

public class OrderService : IOrderService
{
    public async Task<OrderDetailsDto> CreateOrderAsync(OrderDto input)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<OrderDetailsDto>> GetOrdersForUserAsync(string buyerEmail)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderDetailsDto> GetOrderByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<OrderDetailsDto>> GetAllDeliveryMethodsAsync()
    {
        throw new NotImplementedException();
    }
}