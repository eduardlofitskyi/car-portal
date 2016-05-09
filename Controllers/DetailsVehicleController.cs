using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.DAO;
using Auto.DAO.Context;
using Auto.DAO.UserFolder;
using Auto.DAO.VehicleFolder;
using Auto.Models;

namespace Auto.Controllers
{
    public class DetailsVehicleController : Controller
    {
        //
        // GET: /DetailsVehicle/

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult DetailsVehicle(FormCollection collection)
        {

            string carId = collection.Get("carId"); //int

            int id = Convert.ToInt32(carId);

            var idUser = ((UserLogin)Session["User"]).Id;

            using (var db = new ProjectContext() )
            {
                var query = from vehicle in db.Vehicles
                    where vehicle.Id.Equals(id)
                    select vehicle;

                var sc = from shopCart in db.ShoppingCarts
                    where idUser.Equals(shopCart.Id)
                    select shopCart;

                foreach (var s in sc)
                {
                    s.Vehicles.Add(query.First());
                }

                db.SaveChanges();
            }
            
            using (var db = new ProjectContext())
            {
                var query = from shopCart in db.ShoppingCarts
                            where shopCart.Id.Equals(idUser)
                            select shopCart;

                List<Vehicle> vehicleList = query.First().Vehicles.ToList();
                Session["Cart"] = vehicleList;
            }


            return Redirect("/Hello/Index");
            //return View("~/Views/Hello/ViewDetailsVehicle.cshtml", myVehicle);
        }

        public ActionResult DeleteFromCart(FormCollection colection)
        {
            List<Vehicle> vehicles = (List<Vehicle>)Session["Cart"];
            string carId = colection.Get("carId");

            int id = Convert.ToInt32(carId);

            var idUser = ((UserLogin)Session["User"]).Id;

            using (var db = new ProjectContext())
            {
                var query = from vehicle in db.Vehicles
                            where vehicle.Id.Equals(id)
                            select vehicle;

                var sc = from shopCart in db.ShoppingCarts
                         where idUser.Equals(shopCart.Id)
                         select shopCart;

                foreach (var s in sc)
                {
                    s.Vehicles.Remove(query.First());
                }

                db.SaveChanges();
            }

            using (var db = new ProjectContext())
            {
                var query = from shopCart in db.ShoppingCarts
                            where shopCart.Id.Equals(idUser)
                            select shopCart;

                List<Vehicle> vehicleList = query.First().Vehicles.ToList();
                Session["Cart"] = vehicleList;
            }

            return Redirect("/Hello/Index");
        }

 

    }
}
