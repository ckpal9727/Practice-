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
        [MaxLength(8)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [MaxLength(10)]
        public string Mobile { get; set; }
        public bool IsAdmin { get; set; } = false;

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
