using AutoMapper;

namespace Practice.API.Profiles
{
    public class User:Profile
    {
        public User()
        {
            CreateMap<Model.UserDto, Entities.Users>().ReverseMap();
        }
    }
}
