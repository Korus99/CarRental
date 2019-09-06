using System.Collections.Generic;
using CarRentalApp.Common.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IAvailabilityBusiness
    {
        void Add(Availability availability);
        void Update(Availability availability);
        Availability Remove(int id);
        Availability Get(int id);
        IEnumerable<Availability> GetAll();
    }
}
