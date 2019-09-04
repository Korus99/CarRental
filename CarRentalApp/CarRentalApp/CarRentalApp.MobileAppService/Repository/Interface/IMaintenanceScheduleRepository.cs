using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IMaintenanceScheduleRepository
    {
        void Add(MaintenanceSchedule item);
        void Update(MaintenanceSchedule item);
        Vehicle Remove(int key);
        Vehicle Get(int id);
        IEnumerable<MaintenanceSchedule> GetAll();
    }
}
