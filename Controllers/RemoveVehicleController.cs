using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.DAO;
using Auto.DAO.VehicleFolder;
using Auto.Models;

namespace Auto.Controllers
{
    public class RemoveVehicleController : Controller
    {
        //
        // GET: /RemoveVehicle/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RemoveVehicle(FormCollection collection)
        {
            VehicleDAO dao = new VehicleDaoOrm();

            string idStr = collection.Get("carId");

            int carId = Convert.ToInt32(idStr);

            dao.DeleteVehicle(carId);

            return Redirect("/Hello/Index");
        }
    }
}
