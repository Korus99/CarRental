using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IMaintenanceScheduleBusiness
    {
        void Add(MaintenanceSchedule item);
        void Update(MaintenanceSchedule item);
        MaintenanceSchedule Remove(int key);
        MaintenanceSchedule Get(int id);
        IEnumerable<MaintenanceSchedule> GetAll();
    }
}
