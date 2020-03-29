using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Udemy_Vidly.Valiadtions;

namespace Udemy_Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }
        //[Minimum18YearsOfAge]
        public DateTime? Birthday { get; set; }
    }
}