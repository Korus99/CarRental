using System;
using System.Collections.Generic;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class MaintenanceData
    {
        public MaintenanceData()
        {
            Availability = new HashSet<AvailabilityData>();
        }

        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int MaintenanceId { get; set; }
        public DateTime? MaintStart { get; set; }
        public string MainEnd { get; set; }
        public bool Completed { get; set; }
        public int? CompletedBy { get; set; }

        public virtual UserData CompletedByNavigation { get; set; }
        public virtual MaintenanceScheduleData MaintenanceNavigation { get; set; }
        public virtual VehicleData Vehicle { get; set; }
        public virtual ICollection<AvailabilityData> Availability { get; set; }
    }
}
