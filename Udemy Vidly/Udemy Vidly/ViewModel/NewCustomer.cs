using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy_Vidly.Models;
using Vidly.Models;

namespace Udemy_Vidly.ViewModel
{
    public class NewCustomer
    {
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}