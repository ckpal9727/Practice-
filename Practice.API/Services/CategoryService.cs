using Microsoft.EntityFrameworkCore;
using Practice.API.DbContexts;
using Practice.API.Entities;

namespace Practice.API.Services

{
    public class CategoryService : ICategoryService
    {
        private readonly InfoContext infoContext;

        public CategoryService(InfoContext infoContext)
        {
            this.infoContext = infoContext;
        }

        public async Task<Category> AddCategory(Category category)
        {
            await infoContext.Categories.AddAsync(category);
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
           return await infoContext.Categories.ToListAsync();

        }

        public async Task<Category> GetCategory(int CategoryId)
        {
           return  await infoContext.Categories.FirstOrDefaultAsync(c=>c.CategoryId == CategoryId);
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            infoContext.Categories.Update(category);
            return category;
        }
    }
}
