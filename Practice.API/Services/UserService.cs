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

        public async Task LoginUser(UserDto userDto)
        {
            /*            if(userDto!=null)
                        {
                            var DecryptPassword=
                        }*/
            await infoContext.User.AddAsync(mapper.Map<Users>(userDto));
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await infoContext.SaveChangesAsync() > 0);
        }
    }
}
