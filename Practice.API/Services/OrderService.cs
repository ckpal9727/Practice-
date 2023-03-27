using Microsoft.EntityFrameworkCore;
using Practice.API.DbContexts;
using Practice.API.Entities;

namespace Practice.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly InfoContext infoContext;

        public OrderService(InfoContext infoContext)
        {
            this.infoContext = infoContext ?? throw new ArgumentNullException(nameof(infoContext));
        }
        public async Task<Order> AddOrder(Order order)
        {
            await infoContext.Orders.AddAsync(order);
            await infoContext.SaveChangesAsync();
            return order;
        }

        public async Task<IEnumerable<Order>> GetAllOrder()
        {
            return await infoContext.Orders.ToListAsync();
        }

        public async Task<Order> GetOrder(int orderId)
        {
            return await infoContext.Orders.SingleOrDefaultAsync(o => o.OrderId == orderId);
        }

        public async Task<Order> UpdateOrder(Order order)
        {
             infoContext.Orders.Update(order);
            await infoContext.SaveChangesAsync();
            return order;
        }
    }
}
