using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.API.Entities
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public Users User { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
