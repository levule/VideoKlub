using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoKlub.Models
{
    public class Min18YearOldCustomer : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Datum rodjenja je obavezan!");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age < 18) ? new ValidationResult("Morate imati minimum 18 godina za clanstvo.") : ValidationResult.Success;
        }
    }
}