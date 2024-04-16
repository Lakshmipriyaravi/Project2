﻿using Cafe_management.Models;

namespace Cafe_management.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<List<Product>> SearchProductsByName(string name);

        Task<List<Product>> GetProductsByCategory(int categoryId);

        Task<Product> AddProduct(Product product);

        Task<Product> UpdateProduct(int id,Product product);
        Task<Product> DeleteProduct(int productId);

    }
}
