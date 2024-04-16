using Cafe_management.Models;

namespace Cafe_management.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(int id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(int id, Category category);
        Task<Category> DeleteCategory(int id);
    }
}
