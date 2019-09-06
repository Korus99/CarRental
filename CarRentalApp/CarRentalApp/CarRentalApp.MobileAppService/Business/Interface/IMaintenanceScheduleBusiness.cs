using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IMaintenanceScheduleBusiness
    {
        void Add(MaintenanceSchedule maintenanceSchedule);
        void Update(MaintenanceSchedule maintenanceSchedule);
        MaintenanceSchedule Remove(int id);
        MaintenanceSchedule Get(int id);
        IEnumerable<MaintenanceSchedule> GetAll();
    }
}
