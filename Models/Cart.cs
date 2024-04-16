using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace Cafe_management.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        //public ICollection<CartProductMap>? CartProductMaps { get; } = new List<CartProductMap>();
        public int UserId { get; set; }
        public Product? Product { get; set; }
        public User? User { get; set; }
        //public Order? Order {  get; set; }
    }
}
