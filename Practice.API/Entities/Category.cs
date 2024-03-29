﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.API.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int CategoryId { get; set; }
        [Required]
        public string CategoriesName { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }

    }
}
