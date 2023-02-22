using AutoMapper;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Practice.API.Model;
using Practice.API.Services;


namespace Practice.API.Controllers
{
    [Route("/user")]
    [ApiController]

    public class UserController:ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserController(IUserService userService,IMapper mapper)
        {
            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateNewUser(UserDto userDto)
        {
            
            await userService.CreateUser(userDto);
            await userService.SaveChangesAsync();
            return userDto;
        }
        [HttpGet("/getUser")]

        public async Task<UserDto> GetSingleUser(string email)
        {
            var Data = await userService.GetSingleUser(email);
            return mapper.Map<UserDto>(Data);

           
        }

        
        [HttpPost("login")]
        public async Task<bool> Login(string emailId,string password)
        {
            return await userService.LoginUser(emailId, password);
        }

    }
}
