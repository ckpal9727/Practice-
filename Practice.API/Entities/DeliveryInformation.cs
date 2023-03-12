using Practice.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.API.Entities
{
    public class DeliveryInformation
    {
        public int DeliveryId { get; set; }
        
        public DeliveryStatus DeliveryStatus { get; set; }
        [Required]
        public string Address { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
