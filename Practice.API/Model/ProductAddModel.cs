using AutoMapper;
using Practice.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Practice.API.Model
{
    public class ProductAddModel
    {


        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public int CategoryId { get; set; }


        
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        private decimal _total;
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public ProductAddModel()
        {
            _total = Price * Quantity;
        }
    }
}
