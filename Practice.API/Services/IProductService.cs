using Practice.API.Entities;
using Practice.API.Profiles;

namespace Practice.API.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProducts();

        
        public Task<Product> GetSingleProduct(int productId);

        public Task<Product> AddProduct(Product product);

        public Task<Product> UpdateProduct(Product product);
    }
}
