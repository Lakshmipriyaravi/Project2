using Cafe_management.Models;

namespace Cafe_management.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(int id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(int id,Category category);
        Task<Category> DeleteCategory(int id);
    }
}
