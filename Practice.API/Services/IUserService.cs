using Practice.API.Model;

namespace Practice.API.Services
{
    public interface IUserService
    {
        Task CreateUser(UserDto userDto);
        Task LoginUser(UserDto userDto);
        Task<bool> SaveChangesAsync();
    }
}
