using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Auto.Models;

namespace Auto.DAO.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<UserLogin> Users { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}