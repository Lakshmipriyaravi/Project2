using System.Net.Http.Headers;

namespace Cafe_management.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? OrderDetail { get; set; }
        public string? Status { get; set; }
        public DateTime OrderDate { get; set; }
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
        
    }
}
