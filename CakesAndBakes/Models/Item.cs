using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CakesAndBakes.Models
{
    public class Item
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ItemName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal ItemPrice { get; set; }
        public byte AvaiableItems { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}