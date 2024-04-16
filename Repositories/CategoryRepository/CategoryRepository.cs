using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Cafe_management.Data;
using Cafe_management.Models;

namespace Cafe_management.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Cafe_managementContext _context;
        public CategoryRepository(Cafe_managementContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategory(int id)
        {
            Category cat = await _context.Categories.FindAsync(id);
            return cat;
        }

        public async Task<Category> AddCategory(Category category)
        {
            
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateCategory(int id,Category category)
        {
            var c = await _context.Categories.FindAsync(id);
            c.CategoryName = category.CategoryName;
            c.ImageUrl = category.ImageUrl;
            await _context.SaveChangesAsync();
            return c;
        }

        public async Task<Category> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }



        
    }
}
