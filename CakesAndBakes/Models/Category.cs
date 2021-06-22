using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CakesAndBakes.Models
{
    public class Category
    {

        [Required]
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }
    }
}