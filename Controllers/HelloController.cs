using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.Models;

namespace Auto.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/
        AutoContext db = new AutoContext();

        public ActionResult Index()
        {
            IEnumerable<Vehicle> vehicles = db.Vehicles;// получаем из бд все объекты Book
            ViewBag.Autos = vehicles;
            return View();
        }

        public ActionResult ViewReg()
        {
            return View();
        }
        public ActionResult ViewPurchase()
        {
            return View();
        }

        public ActionResult ViewLogin()
        {
            return View();
        }

        public ActionResult ViewRent()
        {
            return View();
        }

        public ActionResult ViewListNewA()
        {
            return View();
        }

        public ActionResult ViewListIOldA()
        {
            return View();
        }

        public ActionResult ViewAddCar()
        {
            return View();
        }
        public ActionResult ViewCarDetails()
        {
            return View();
        }
    }
}
