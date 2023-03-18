using Practice.API.Entities;

namespace Practice.API.Services
{
    public interface ICategoryService
    {
        public Task<Category> AddCategory(Category category);
        public Task<Category> UpdateCategory(Category category);
        public Task<Category> GetCategory(int CategoryId);
        public Task<IEnumerable<Category>> GetAllCategories();
    }
}
