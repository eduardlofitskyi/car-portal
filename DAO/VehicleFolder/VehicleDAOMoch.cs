using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Auto.Models;

namespace Auto.DAO.VehicleFolder
{
    
    public class VehicleDAOMoch : VehicleDAO
    {

        private List<Vehicle> list = new List<Vehicle>();

        public List<string> GetAllDistModels()
        {
            return new List<string>();
        }

        public List<string> GetAllDistVehicles()
        {
            return new List<string>();
        }

        public Vehicle GetById(int id)
        {
            return list[0];
        }

        public void DeleteVehicle(int id)
        {
            
        }

        public void AddNewVehicle(Vehicle vehicle)
        {
            
        }
   
        public List<Vehicle> getAll()
        {
            
            return list;
        }

        public List<Vehicle> getByName(string fBrand, string fModel, int minDate, int maxDate, int minPrice, int maxPrice)
        {
            
            var listResult = new List<Vehicle>();
            foreach (var vehicle in list)
            {
                
                
            }
            return listResult;
        }

        public List<Vehicle> GetByNameOld(string fBrand, string fModel, int minDate, int maxDate, int minPrice,
            int maxPrice)
        {
            return list;
        }
    }
}