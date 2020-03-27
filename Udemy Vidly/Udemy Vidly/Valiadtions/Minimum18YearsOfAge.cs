using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Udemy_Vidly.Valiadtions
{
    public class Minimum18YearsOfAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if(customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success;
            }
            if (customer.Birthday == null)
                return new ValidationResult("Birthdate is required.");
            var age = DateTime.Today.Year - customer.Birthday.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be atleast 18 years old");
        }
    }
}