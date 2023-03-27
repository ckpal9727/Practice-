using AutoMapper;
using Practice.API.Entities;
using Practice.API.Model;

namespace Practice.API.Profiles
{
    public class Orders:Profile
    {
        public Orders()
        {
            CreateMap<Order,AddOrderModel>().ReverseMap();
        }
    }
}
