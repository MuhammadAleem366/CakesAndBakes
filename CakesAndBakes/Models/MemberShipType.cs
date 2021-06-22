using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CakesAndBakes.Models
{
    public class MemberShipType
    {

        public byte Id { get; set; }
        public string MememberShipName { get; set; }
        public decimal SignUpPrice { get; set; }
    }
}