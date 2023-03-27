using Practice.API.Entities;

namespace Practice.API.Services
{
    public interface ICartService
    {
        public Task<IEnumerable<Cart>> GetAllCart();
        public Task<Cart> GetCartById(int cartId);
        public Task<Cart> AddCart(Cart cart);
        public Task<Cart> UpdateCart(Cart cart);
    }
}
