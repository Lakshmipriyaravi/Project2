using Microsoft.EntityFrameworkCore;
using Cafe_management.Data;
using Cafe_management.Exceptions;
using Cafe_management.Models;

namespace Cafe_management.Repositories.CartRepository
{
    public class CartRepository : ICartRepository
    {
        private readonly Cafe_managementContext _context;
        public CartRepository(Cafe_managementContext context)
        {
            _context = context;
        }

        public async Task<List<Cart>> GetCarts()
        {
            return await _context.Carts.ToListAsync();
        }

        public async Task<Cart> GetCart(int id)
        {
            return await _context.Carts.FindAsync(id);
        }

        public async Task<Cart> AddCart(Cart cart)
        {
            var product = await _context.Products.FindAsync(cart.ProductId);
            var user = await _context.Users.FindAsync(cart.UserId);
            if (product == null || user == null)
            {
                throw new NoItemsInCartException("Please add any items to cart");
            }
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
            return cart;
        }

        public async Task<Cart> EditCart(int id, Cart cart)
        {
            var car = await _context.Carts.FindAsync(id);
            if(car != null)
            {
                 car.Quantity = cart.Quantity;
                await _context.SaveChangesAsync();
            }
            return car;
        }

        public async Task<Cart> DeleteCart(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return cart;
        }
    }
}
