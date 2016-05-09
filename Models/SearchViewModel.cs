using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class SearchViewModel
    {
        public List<Vehicle> VehicleList { get; set; }

        public List<String> BrandList { get; set; }

        public List<String> ModelList { get; set; }
    }
}