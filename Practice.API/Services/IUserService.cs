using Practice.API.Model;

namespace Practice.API.Services
{
    public interface IUserService
    {
        Task<UserDto> GetSingleUser(string username);
        Task CreateUser(UserDto userDto);
        Task<string> LoginUser(string email,string password);
        Task<bool> SaveChangesAsync();
    }
}
