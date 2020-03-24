using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Detalis(int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Aaman" },
                new Customer { Id = 2, Name = "Karan" }
            };
        }
    }
}