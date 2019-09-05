using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IAvailabilityBusiness
    {
        void Add(Availability item);
        void Update(Availability item);
        Availability Remove(int key);
        Availability Get(int id);
        IEnumerable<Availability> GetAll();
    }
}
