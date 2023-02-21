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

        public UserController(IUserService userService)
        {
            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateNewUser(UserDto userDto)
        {
            
            await userService.CreateUser(userDto);
            await userService.SaveChangesAsync();
            return userDto;
        }
        [HttpGet("/getUser")]

        public async Task<ActionResult> GetSingleUser(string email)
        {
            await userService.GetSingleUser(email);
            return Ok();
        }

        
        [HttpPost("login")]
        public async Task<ActionResult> Login(string emailId,string password)
        {
            return Ok();
        }

    }
}
