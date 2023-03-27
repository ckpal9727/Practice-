using AutoMapper;
using Practice.API.Entities;
using Practice.API.Model;

namespace Practice.API.Profiles
{
    public class Categories:Profile
    {
        public Categories()
        {
            CreateMap<AddCategoryModel,Category>().ReverseMap();
        }
    }
}
