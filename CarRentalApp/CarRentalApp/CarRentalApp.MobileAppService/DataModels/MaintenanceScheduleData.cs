using System;
using System.Collections.Generic;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class MaintenanceScheduleData
    {
        public MaintenanceScheduleData()
        {
            MaintenanceNavigation = new HashSet<MaintenanceData>();
        }

        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Maintenance { get; set; }
        public DateTime? DueDate { get; set; }
        public int? DueMile { get; set; }
        public bool Recurring { get; set; }
        public DateTimeOffset? NextDate { get; set; }
        public int? NewMile { get; set; }

        public virtual VehicleData Vehicle { get; set; }
        public virtual ICollection<MaintenanceData> MaintenanceNavigation { get; set; }
    }
}
