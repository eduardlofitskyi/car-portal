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
    public class AddVehicleController : Controller
    {
        //
        // GET: /AddVehicle/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddVehicle(FormCollection collection)
        {
            VehicleDAO dao = new VehicleDaoOrm();

            string fBrand = collection.Get("brand");
            string fModel = collection.Get("model");
            string fRelDate = collection.Get("relDate"); //int
            string fColor = collection.Get("color");
            string fTitle = collection.Get("carTitle");

            //bool Выпадающий список, с вариантами "Ручная"-false или "Автоматическая" - true
            string fAutoKPP = collection.Get("autoKPP");

            string fCapacity = collection.Get("capacity"); //double
            string fPrice = collection.Get("price"); //int

            //bool Выпадающий список, с вариантами "Новая"-false или "Подержанная" - true
            string fIsUses = collection.Get("isUses"); //bool

            int fReleaseDate = Convert.ToInt32(fRelDate);
            double fCap = Convert.ToDouble(fCapacity);
            int fPr = Convert.ToInt32(fPrice);

            bool fAutoKP = false;
            if (fAutoKPP == "Автоматическая")
            {
                fAutoKP = true;
            }
            bool fUsed = false;
            if (fIsUses == "Подержанная")
            {
                fUsed = true;
            }
            var vehicle = new Vehicle()
            {
                autoKPP = fAutoKP,
                brand = fBrand,
                capacity = fCap,
                color = fColor,
                isUses = fUsed,
                model = fModel,
                price = fPr,
                releaseDate = fReleaseDate,
                title = fTitle
            };

            dao.AddNewVehicle(vehicle);

            return Redirect("/Hello/Index");
        }
    }
}
