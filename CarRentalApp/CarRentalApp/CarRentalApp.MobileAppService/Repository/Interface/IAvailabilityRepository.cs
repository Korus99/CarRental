using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IAvailabilityRepository
    {
        void Add(Availability item);
        void Update(Availability item);
        Vehicle Remove(int key);
        Vehicle Get(int id);
        IEnumerable<Availability> GetAll();
    }
}
