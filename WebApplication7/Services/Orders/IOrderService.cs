using WebApplication7.Models;

namespace WebApplication7.Services.Orders
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrders();
        Task AddOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int id);
    }
}
