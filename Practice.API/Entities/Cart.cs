using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.API.Entities
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
       
        public int UserId { get; set; }
        public virtual Users User { get; set; }

        public int ProductId { get; set; }
        [Required]
        public virtual  Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
