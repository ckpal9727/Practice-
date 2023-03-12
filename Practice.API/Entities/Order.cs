using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Practice.API.Enums;

namespace Practice.API.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public Users User { get; set; }
        public int TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
