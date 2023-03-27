using Microsoft.EntityFrameworkCore;
using Practice.API.DbContexts;
using Practice.API.Entities;

namespace Practice.API.Services
{
    public class ProductService : IProductService
    {
        private readonly InfoContext infoContext;

        public ProductService(InfoContext infoContext)
        {
            this.infoContext = infoContext;
        }
        public async Task<Product> AddProduct(Product product)
        {
            await infoContext.Products.AddAsync(product);
            await infoContext.SaveChangesAsync();
            return product;
        }

      

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await infoContext.Products.ToListAsync();
        }

        public async Task<Product> GetSingleProduct(int productId)
        {
            return await infoContext.Products.FirstOrDefaultAsync(c => c.ProductId == productId);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
             infoContext.Products.Update(product);
            await infoContext.SaveChangesAsync();
            return product;
        }
    }
}
