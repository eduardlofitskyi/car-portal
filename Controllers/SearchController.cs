using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.DAO;
using Auto.DAO.VehicleFolder;
using Auto.Models;
using Microsoft.Ajax.Utilities;

namespace Auto.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult FindNew()
        {
            VehicleDAO dao = new VehicleDaoOrm();

            List<String> brands = dao.GetAllDistVehicles();
            List<String> models = dao.GetAllDistModels();

            SearchViewModel search = new SearchViewModel
            {
                BrandList = brands,
                ModelList = models
            };

            return View("~/Views/Hello/ViewListNewA.cshtml", search);
        }

        public ActionResult FindOld()
        {
            VehicleDAO dao = new VehicleDaoOrm();

            List<String> brands = dao.GetAllDistVehicles();
            List<String> models = dao.GetAllDistModels();

            SearchViewModel search = new SearchViewModel
            {
                BrandList = brands,
                ModelList = models
            };

            return View("~/Views/Hello/ViewListIOldA.cshtml", search);
        }

        public ActionResult GetAll()
        {
            VehicleDAO dao = new VehicleDaoOrm();

            List<Vehicle> vehicleList = dao.getAll();

            SearchViewModel search = new SearchViewModel
            {
                VehicleList = vehicleList
            };

            return View("GetAllVehicle", search);
        }

        public ActionResult GetForDelete()
        {
            VehicleDAO dao = new VehicleDaoOrm();

            List<Vehicle> vehicleList = dao.getAll();

            SearchViewModel search = new SearchViewModel
            {
                VehicleList = vehicleList
            };

            return View("~/Views/Hello/ViewDeleteVehicle.cshtml", search);
        }

        public ActionResult Search(FormCollection collection)
        {
            VehicleDAO dao = new VehicleDaoOrm();

            string brand = collection.Get("carBrand");
            string model = collection.Get("carModel");
            string minRelDate = collection.Get("minRelDate");
            string maxRelDate = collection.Get("maxRelDate");
            string minPrice = collection.Get("minPrice");
            string maxPrice = collection.Get("maxPrice");

            int minDate = 0;
            int maxDate = Int32.MaxValue;
            int minPr = 0;
            int maxPr = Int32.MaxValue;

            if (minRelDate != "")
            {
                minDate = Convert.ToInt32(minRelDate);
            }
            if(maxRelDate != "")
            {
                maxDate = Convert.ToInt32(maxRelDate);
            }
            if (minPrice != "")
            {
                minPr = Convert.ToInt32(minPrice);
            }
            if (maxPrice != "")
            {
                maxPr = Convert.ToInt32(maxPrice);
            }

            List<Vehicle> vehicleList = dao.getByName(brand, model, minDate, maxDate, minPr, maxPr);

            SearchViewModel search = new SearchViewModel
            {
                VehicleList = vehicleList
            };
            
            //return Redirect("/Hello/ViewListNewA");
            return View("Search", search);
        }

        public ActionResult SearchOld(FormCollection collection)
        {
            VehicleDAO dao = new VehicleDaoOrm();

            string brand = collection.Get("carBrand");
            string model = collection.Get("carModel");
            string minRelDate = collection.Get("minRelDate");
            string maxRelDate = collection.Get("maxRelDate");
            string minPrice = collection.Get("minPrice");
            string maxPrice = collection.Get("maxPrice");

            int minDate = 0;
            int maxDate = Int32.MaxValue;
            int minPr = 0;
            int maxPr = Int32.MaxValue;

            if (minRelDate != "")
            {
                minDate = Convert.ToInt32(minRelDate);
            }
            if (maxRelDate != "")
            {
                maxDate = Convert.ToInt32(maxRelDate);
            }
            if (minPrice != "")
            {
                minPr = Convert.ToInt32(minPrice);
            }
            if (maxPrice != "")
            {
                maxPr = Convert.ToInt32(maxPrice);
            }

            List<Vehicle> vehicleList = dao.GetByNameOld(brand, model, minDate, maxDate, minPr, maxPr);

            SearchViewModel search = new SearchViewModel
            {
                VehicleList = vehicleList
            };

            return View("SearchOld", search);
        }

    }
}
