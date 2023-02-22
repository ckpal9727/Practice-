using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Practice.API.Entities
{
    public class Users
    {
        

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(35)]
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string Mobile { get; set; }
        public bool IsAdmin { get; set; } = false;

        public UserRoles userRoles { get; set; }

        //Remaining Work For Email Validation
        bool ValidateMail()
        {
            if (Email== null)
            {

            }
            var mail = new MailAddress(Email);
            bool isValidEmail = mail.Host.Contains(".");
            if (!isValidEmail)
            {
               return false;
            }
            else
            {
                return true;
            }

            
        }
        
    }
}
