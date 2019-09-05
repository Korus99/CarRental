using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IMaintenanceBusiness
    {
        void Add(Vehicle item);
        void Update(Vehicle item);
        Vehicle Remove(string key);
        Vehicle Get(string id);
        IEnumerable<Vehicle> GetAll();
    }
}
