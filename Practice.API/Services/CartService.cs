using Microsoft.EntityFrameworkCore;
using Practice.API.DbContexts;
using Practice.API.Entities;

namespace Practice.API.Services
{
    public class CartService : ICartService
    {
        private readonly InfoContext infoContext;

        public CartService(InfoContext infoContext)
        {
            this.infoContext = infoContext ?? throw new ArgumentNullException(nameof(infoContext));
        }
        public async Task<Cart> AddCart(Cart cart)
        {
            await infoContext.Carts.AddAsync(cart);
            await infoContext.SaveChangesAsync();
            return cart;
        }

        public async Task<IEnumerable<Cart>> GetAllCart()
        {
            return await infoContext.Carts.ToListAsync();
        }

        public async Task<Cart> GetCartById(int cartId)
        {
            return await infoContext.Carts.FirstOrDefaultAsync(c => c.CartId ==cartId);
        }

        public async Task<Cart> UpdateCart(Cart cart)
        {
             infoContext.Carts.Update(cart);
            await infoContext.SaveChangesAsync();
            return cart;
        }
    }
}
