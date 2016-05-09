using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class ShopingCartViewModel
    {
        public UserLogin User { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}