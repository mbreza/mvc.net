using CarRent.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class Customer
    {
        public Int32 ID { get; set; }
        [DisplayName("FirstName"), Required(ErrorMessage = "Enter firstname.")]
        public string FirstName { get; set; }
        [DisplayName("LastName"), Required(ErrorMessage = "Enter lastname.")]
        public string LastName { get; set; }
        [Required]
        [Pesel(ErrorMessage = "Wrong pesel!")]
        public string Pesel { get; set; }
        public string Address { get; set; }

    }

}