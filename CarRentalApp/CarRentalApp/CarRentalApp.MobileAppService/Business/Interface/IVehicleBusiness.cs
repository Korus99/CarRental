using System.Collections.Generic;
using CarRentalApp.Common.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IVehicleBusiness
    {
        void Add(Vehicle vehicle);
        void Update(Vehicle vehicle);
        Vehicle Remove(int id);
        Vehicle Get(int id);
        IEnumerable<Vehicle> GetAll();
    }
}
