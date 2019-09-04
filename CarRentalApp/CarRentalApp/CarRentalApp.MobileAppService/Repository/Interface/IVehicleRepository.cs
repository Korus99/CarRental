using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IVehicleRepository
    {
        void Add(Vehicle item);
        void Update(Vehicle item);
        Vehicle Remove(int key);
        Vehicle Get(int id);
        IEnumerable<Vehicle> GetAll();
    }
}
