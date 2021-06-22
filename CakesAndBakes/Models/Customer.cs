using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CakesAndBakes.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        public DateTime BirthDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }


        public MemberShipType MemberShipType { get; set; }
        [Required]
        public byte MemberShipTypeId { get; set; }

        public Order Order { get; set; }
        public int? OrderId { get; set; }
    }
}