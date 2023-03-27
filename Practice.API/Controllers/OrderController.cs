using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Practice.API.Entities;
using Practice.API.Model;
using Practice.API.Services;

namespace Practice.API.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IOrderService orderService;

        public OrderController(IMapper mapper,IOrderService orderService)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }
        [HttpGet("getAllOrder")]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrder()
        {
            return Ok(await orderService.GetAllOrder());
        }
        [HttpGet]
        public async Task<ActionResult<Order>> GetSingleOrder(int orderId)
        {
            if (orderId != null)
            {
                return Ok(await orderService.GetOrder(orderId) != null) ;
                
            }
            return null;
        }
        [HttpPost]
        public async Task<ActionResult<Order>> AddOrder(AddOrderModel addOrderModel)
        {
            var addedOrder = await orderService.AddOrder(mapper.Map<Order>(addOrderModel));
            if(addedOrder != null)
            {
                return Ok(addedOrder);
            }
            return BadRequest("Not Added Order");
        }
        [HttpPut]
        public async Task<ActionResult<Order>> UpdateOrder(AddOrderModel addOrderModel,int orderId)
        {
            var existOrder = await orderService.GetOrder(orderId);
            if(existOrder != null)
            {
                var updatedOrder = await orderService.UpdateOrder(mapper.Map(addOrderModel, existOrder));
                if(updatedOrder != null)
                {
                    return Ok(updatedOrder);
                }
                return BadRequest("Not Updated");
            }
            return BadRequest("Not Updated");
        }
    }
}
