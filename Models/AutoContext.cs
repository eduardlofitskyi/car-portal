using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Auto.Models;


namespace Auto.Models
{
    public class AutoContext: DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}