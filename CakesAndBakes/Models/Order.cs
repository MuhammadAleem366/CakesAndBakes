using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CakesAndBakes.Models
{
    public class Order
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal OrderTotalPrice { get; set; }

        public Item Item { get; set; }
        [Required]
        public int ItemId { get; set; }
    }
}