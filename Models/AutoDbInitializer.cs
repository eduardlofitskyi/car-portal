using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Auto.Models;

namespace Auto.Models
{
    public class AutoDbInitializer : DropCreateDatabaseAlways<AutoContext>
    {
        protected override void Seed(AutoContext db)
        {
           
        }
    }
}