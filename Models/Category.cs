namespace Cafe_management.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
