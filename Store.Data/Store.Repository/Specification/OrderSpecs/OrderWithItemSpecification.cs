using System.Linq.Expressions;
using Store.Data.Entities.OrderEntities;

namespace Store.Repository.Specification.OrderSpecs;

public class OrderWithItemSpecification : BaseSpecification<Order>
{
    public OrderWithItemSpecification(string buyerEmail) : base(o => o.BuyerEmail == buyerEmail)
    {
        AddInclude(order => order.DeliveryMethod);
        AddInclude(order => order.OrderItems);
        AddOrderByDescending(order => order.OrderDate);
    }
    public OrderWithItemSpecification(Guid id) : base(o => o.Id == id)
    {
        AddInclude(order => order.DeliveryMethod);
        AddInclude(order => order.OrderItems);
    }
}