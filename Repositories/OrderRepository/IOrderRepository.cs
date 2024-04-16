using Cafe_management.Models;

namespace Cafe_management.Repositories.OrderRepository
{
    public interface IOrderRepository
    {
        Task<Order> PlaceOrder(Order order);
        Task<List<Order>> GetOrders();
        Task<Order> GetOrder(int id);
        Task<Order> EditOrder(int id, Order order);
        Task<Order> DeleteOrder(int id);
        Task<int> GetOrderCount();
    }
}
