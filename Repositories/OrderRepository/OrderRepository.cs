using Microsoft.EntityFrameworkCore;
using Cafe_management.Data;
using Cafe_management.Models;

namespace Cafe_management.Repositories.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Cafe_managementContext _context;
        public OrderRepository(Cafe_managementContext context)
        {
            _context = context;
        }

        public async Task<Order> DeleteOrder(int id)
        {
            var ord = await _context.Orders.FindAsync(id);
            if (ord != null)
            {
                _context.Orders.Remove(ord);
                _context.SaveChangesAsync();
            }
            return ord;

        }

        public async Task<Order> EditOrder(int id, Order order)
        {
            var ord = await _context.Orders.FindAsync(id);
            if(ord != null)
            {
                ord.OrderDetail = order.OrderDetail;
                ord.OrderDate = order.OrderDate;
                ord.Status = order.Status;
                ord.CartId = order.CartId;
            }
            return ord;
        }

        public async Task<Order> GetOrder(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> PlaceOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<int> GetOrderCount()
        {
            return await _context.Orders.CountAsync();
        }
    }
}
