﻿using Practice.API.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.API.Entities
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
       
        public Guid CartNumber { get; set; }
        public int UserId { get; set; }
        public virtual Users User { get; set; }

        public ICollection<Product> Products { get; set; } =new List<Product>();
       

        
    }
}
