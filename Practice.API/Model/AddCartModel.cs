using Practice.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Practice.API.Model
{
    public class AddCartModel
    {
        public int UserId { get; set; }

       public ICollection<ProductAddModel> Products { get; set;}
           
      
    }

}
