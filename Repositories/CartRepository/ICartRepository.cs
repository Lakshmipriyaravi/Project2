﻿using Cafe_management.Models;

namespace Cafe_management.Repositories.CartRepository
{
    public interface ICartRepository
    {
        Task<List<Cart>> GetCarts();
        Task<Cart> GetCart(int id);
        Task<Cart> AddCart(Cart cart);
        Task<Cart> EditCart(int id,Cart cart);
        Task<Cart> DeleteCart(int id);
    }
}
