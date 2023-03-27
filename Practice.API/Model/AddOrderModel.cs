using Practice.API.Entities;
using Practice.API.Enums;

namespace Practice.API.Model
{
    public class AddOrderModel
    {
        public int UserId { get; set; }
        public AddCartModel Cart { get; set; }
        public int TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
