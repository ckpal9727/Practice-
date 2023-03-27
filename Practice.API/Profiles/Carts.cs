using AutoMapper;
using Practice.API.Entities;
using Practice.API.Model;

namespace Practice.API.Profiles
{
    public class Carts:Profile
    {
        public Carts()
        {
            CreateMap<Cart,AddCartModel>().ReverseMap();
        }
    }
}
