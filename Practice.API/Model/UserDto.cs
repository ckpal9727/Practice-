using Practice.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Practice.API.Model
{
    public class UserDto
    {
        

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Mobile { get; set; }
        
        public UserRoles userRoles { get; set; }
    }
}
