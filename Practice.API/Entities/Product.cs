﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practice.API.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } 
        public string ProductDescription { get; set; }
       
        public int CategoryId { get; set;}
        
        public  virtual Category Category { get; set; }
        
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        private decimal _total;
        public decimal Total { get { return _total; } set { _total = value; } }
        public Product()
        {
            _total = Price * Quantity;
        }
        
       
    }
}
