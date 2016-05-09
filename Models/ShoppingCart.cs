using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class ShoppingCart
    {

        [Key, ForeignKey("UserLogin")]
        public int Id { get; set; }
        public virtual UserLogin UserLogin { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}