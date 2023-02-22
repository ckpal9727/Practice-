using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Practice.API.Common;
using Practice.API.DbContexts;
using Practice.API.Entities;
using Practice.API.Model;

namespace Practice.API.Services
{
    public class UserService : IUserService
    {
        private readonly InfoContext infoContext;
        private readonly IMapper mapper;

        public UserService(InfoContext infoContext,IMapper mapper)
        {
            this.infoContext = infoContext ?? throw new ArgumentNullException(nameof(infoContext));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task CreateUser(UserDto userDto)
        {
            if(userDto != null)
            {
                var EncPassword = CommonMethod.ConvertToEncrypt(userDto.Password);
                userDto.Password = EncPassword;
                await infoContext.User.AddAsync(mapper.Map<Users>(userDto));
            }
            
        }

        public async Task<UserDto> GetSingleUser(string email)
        {
            var ExistUser=await infoContext.User.FirstOrDefaultAsync<Users>(s=>s.Email==email);
            return mapper.Map<UserDto>(ExistUser);
        }

        public async Task<bool> LoginUser(string email, string password)
        {
           UserDto ExistUser=await GetSingleUser(email); 
            if(ExistUser!=null)
            {
                var DecodePassword=CommonMethod.ConvertToDecrypt(ExistUser.Password);
                if(DecodePassword==password)
                {
                    return true;
                }
            }
            return false;

        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await infoContext.SaveChangesAsync() > 0);
        }
    }
}
