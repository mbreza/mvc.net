using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class Rent
    {
        public Int32 ID { get; set; }
        public Int32 CustomersID { get; set; }
        [DisplayName("Car"), Required(ErrorMessage = "Enter car.")]
        public string Car { get; set; }
        [DisplayName("Payment"), Required(ErrorMessage = "Enter payment.")]
        public string Payment { get; set; }

        public virtual Customer Customers { get; set; }
    }
}