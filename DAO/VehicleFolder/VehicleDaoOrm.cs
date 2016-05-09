using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.DAO.Context;
using Auto.Models;

namespace Auto.DAO.VehicleFolder
{
    public class VehicleDaoOrm : VehicleDAO
    {
        //
        // GET: /VehicleDaoOrm/
        private List<Vehicle> list = new List<Vehicle>();

        public void AddNewVehicle(Vehicle vehicle)
        {
            using (var db = new ProjectContext())
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }
        }

        public List<Vehicle> getAll()
        {
            var listResult = new List<Vehicle>();
            using (var db = new ProjectContext())
            {
                var query = from vehicle in db.Vehicles
                    select vehicle;

                foreach (var v in query)
                {
                    listResult.Add(v);
                }
            }
            return listResult;
        }

        public List<string> GetAllDistVehicles()
        {
            var listResult = new List<string>();
            using (var db = new ProjectContext())
            {
                var query = (from vehicle in db.Vehicles
                            select vehicle.brand).Distinct();

                foreach (var v in query)
                {
                    listResult.Add(v);
                }
            }
            return listResult;
        }

        public List<string> GetAllDistModels()
        {
            var listResult = new List<string>();
            using (var db = new ProjectContext())
            {
                var query = (from vehicle in db.Vehicles
                             select vehicle.model).Distinct();

                foreach (var v in query)
                {
                    listResult.Add(v);
                }
            }
            return listResult;
        }

        public void DeleteVehicle(int id)
        {
            using (var db = new ProjectContext())
            {
                var query = from vehicle in db.Vehicles
                    where vehicle.Id.Equals(id)
                    select vehicle;
                foreach (var v in query)
                {
                    db.Vehicles.Remove(v);
                }
                db.SaveChanges();
            }
        }

        public Vehicle GetById(int id)
        {
            using (var db = new ProjectContext())
            {
                var query = from vehicle in db.Vehicles
                    where vehicle.Id.Equals(id)
                    select vehicle;

                return query.First();
            }
        }

        public List<Vehicle> getByName(string fBrand, string fModel, int minDate, int maxDate, int minPrice, int maxPrice)
        {
            if (fBrand != "Выберите марку" && fModel != "")
            {
                var listResult = new List<Vehicle>();
                using (var db = new ProjectContext())
                {
                    var query = from vehicle in db.Vehicles
                                where vehicle.brand.Equals(fBrand) && vehicle.model.Equals(fModel) && vehicle.releaseDate >= minDate
                                && vehicle.releaseDate <= maxDate && vehicle.price >= minPrice && vehicle.price <= maxPrice && vehicle.isUses.Equals(false)
                                select vehicle;


                    foreach (var v in query)
                    {
                        listResult.Add(v);
                    }
                }
                return listResult;
            }
            else if (fBrand != "Выберите марку" && fModel == "")
            {
                var listResult = new List<Vehicle>();
                using (var db = new ProjectContext())
                {
                    var query = from vehicle in db.Vehicles
                                where vehicle.brand.Equals(fBrand) && vehicle.releaseDate >= minDate
                                && vehicle.releaseDate <= maxDate && vehicle.price >= minPrice && vehicle.price <= maxPrice && vehicle.isUses.Equals(false)
                                select vehicle;

                    foreach (var v in query)
                    {
                        listResult.Add(v);
                    }
                }
                return listResult;
            }
            else
            {
                var listResult = new List<Vehicle>();
                using (var db = new ProjectContext())
                {
                    var query = from vehicle in db.Vehicles
                                where vehicle.releaseDate >= minDate
                                && vehicle.releaseDate <= maxDate && vehicle.price >= minPrice && vehicle.price <= maxPrice && vehicle.isUses.Equals(false)
                                select vehicle;

                    foreach (var v in query)
                    {
                        listResult.Add(v);
                    }
                }
                return listResult;
            }
        }

        public List<Vehicle> GetByNameOld(string fBrand, string fModel, int minDate, int maxDate, int minPrice,
            int maxPrice)
        {
            if (fBrand != "Выберите марку" && fModel != "")
            {
                var listResult = new List<Vehicle>();
                using (var db = new ProjectContext())
                {
                    var query = from vehicle in db.Vehicles
                                where vehicle.brand.Equals(fBrand) && vehicle.model.Equals(fModel) && vehicle.releaseDate >= minDate
                                && vehicle.releaseDate <= maxDate && vehicle.price >= minPrice && vehicle.price <= maxPrice && vehicle.isUses.Equals(true)
                                select vehicle;


                    foreach (var v in query)
                    {
                        listResult.Add(v);
                    }
                }
                return listResult;
            }
            else if (fBrand != "Выберите марку" && fModel == "")
            {
                var listResult = new List<Vehicle>();
                using (var db = new ProjectContext())
                {
                    var query = from vehicle in db.Vehicles
                                where vehicle.brand.Equals(fBrand) && vehicle.releaseDate >= minDate
                                && vehicle.releaseDate <= maxDate && vehicle.price >= minPrice && vehicle.price <= maxPrice && vehicle.isUses.Equals(true)
                                select vehicle;

                    foreach (var v in query)
                    {
                        listResult.Add(v);
                    }
                }
                return listResult;
            }
            else
            {
                var listResult = new List<Vehicle>();
                using (var db = new ProjectContext())
                {
                    var query = from vehicle in db.Vehicles
                                where vehicle.releaseDate >= minDate
                                && vehicle.releaseDate <= maxDate && vehicle.price >= minPrice && vehicle.price <= maxPrice && vehicle.isUses.Equals(true)
                                select vehicle;

                    foreach (var v in query)
                    {
                        listResult.Add(v);
                    }
                }
                return listResult;
            }
        }
    }
}
