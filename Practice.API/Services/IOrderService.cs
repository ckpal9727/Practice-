using Practice.API.Entities;

namespace Practice.API.Services
{
    public interface IOrderService
    {
        public Task<IEnumerable<Order>> GetAllOrder();
        public Task<Order> GetOrder(int OrderId);
        public Task<Order> AddOrder(Order order);
        public Task<Order> UpdateOrder(Order order);
    }
}
