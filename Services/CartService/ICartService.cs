using Cafe_management.Models;

namespace Cafe_management.Services.CartService
{
    public interface ICartService
    {
        Task<List<Cart>> GetCarts();
        Task<Cart> GetCart(int id);
        Task<Cart> AddCart(Cart cart);
        Task<Cart> EditCart(int id,Cart cart);
        Task<Cart> DeleteCart(int id);
    }
}
