using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class CorporationContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}