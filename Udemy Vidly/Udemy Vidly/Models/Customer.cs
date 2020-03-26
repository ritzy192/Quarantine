using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Udemy_Vidly.Models;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipTypes MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthday { get; set; }
    }
}