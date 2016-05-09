using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto.Models;

namespace Auto.DAO
{
    interface VehicleDAO
    {
        void AddNewVehicle(Vehicle vehicle);
        List<Vehicle> getAll();
        List<Vehicle> getByName(string fBrand, string fModel, int minDate, int maxDate, int minPrice, int maxPrice);
        List<Vehicle> GetByNameOld(string fBrand, string fModel, int minDate, int maxDate, int minPrice, int maxPrice);
        void DeleteVehicle(int id);
        Vehicle GetById(int id);
        List<string> GetAllDistVehicles();
        List<string> GetAllDistModels();
    }
}
