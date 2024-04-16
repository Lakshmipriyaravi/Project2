using Microsoft.AspNetCore.Mvc;
using Cafe_management.Models;

namespace Cafe_management.Services.ProductServices
{
    public interface IProductService 
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetProductsByCategory(int categoryId);
        Task<List<Product>> SearchProductsByName(string name);
        Task<Product> GetProduct(int id);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(int id,Product product);
        Task<Product> DeleteProduct(int id);
    }
}
