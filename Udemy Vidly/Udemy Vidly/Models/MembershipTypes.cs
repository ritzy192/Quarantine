using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Udemy_Vidly.Models
{
    public class MembershipTypes
    {
        public byte Id { get; set; }
        [StringLength(50)]
        public string Name   { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}