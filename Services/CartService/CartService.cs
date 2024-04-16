using Microsoft.EntityFrameworkCore;
using Cafe_management.Exceptions;
using Cafe_management.Models;
using Cafe_management.Repositories.CartRepository;

namespace Cafe_management.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;
        public CartService(ICartRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Cart>> GetCarts()
        {
            return await _repository.GetCarts();
        }

        public async Task<Cart> GetCart(int id)
        {
            var cart = await _repository.GetCart(id);
            if(cart == null)
            {
                throw new CartNotFoundException("Cart is not found with this id");
            }
            return cart;
        }

        public async Task<Cart> AddCart(Cart cart)
        {
            return await _repository.AddCart(cart);
        }

        public async Task<Cart> EditCart(int id, Cart cart)
        {
            var car = await _repository.EditCart(id,cart);
            if(car == null)
            {
                throw new CartNotFoundException("Cart is not found with this id");
            }
            return car;
        }

        public async Task<Cart> DeleteCart(int id)
        {
            var cart = await _repository.GetCart(id);
            if(cart == null)
            {
                throw new CartNotFoundException("Cart with this not found");
            }
            return await _repository.DeleteCart(id);
        }
    }
}
