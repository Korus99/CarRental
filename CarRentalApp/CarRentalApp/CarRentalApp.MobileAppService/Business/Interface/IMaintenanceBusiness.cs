using System.Collections.Generic;
using CarRentalApp.Common.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IMaintenanceBusiness
    {
        void Add(Maintenance maintenance);
        void Update(Maintenance maintenance);
        Maintenance Remove(int id);
        Maintenance Get(int id);
        IEnumerable<Maintenance> GetAll();
    }
}
