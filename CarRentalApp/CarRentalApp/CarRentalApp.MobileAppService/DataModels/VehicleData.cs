using System;
using System.Collections.Generic;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class VehicleData
    {
        public VehicleData()
        {
            Availability = new HashSet<AvailabilityData>();
            Maintenance = new HashSet<MaintenanceData>();
            MaintenanceSchedule = new HashSet<MaintenanceScheduleData>();
        }

        public int Id { get; set; }
        public string Vin { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string License { get; set; }
        public string State { get; set; }
        public int Mileage { get; set; }
        public bool Removed { get; set; }
        public string Location { get; set; }

        public virtual ICollection<AvailabilityData> Availability { get; set; }
        public virtual ICollection<MaintenanceData> Maintenance { get; set; }
        public virtual ICollection<MaintenanceScheduleData> MaintenanceSchedule { get; set; }
    }
}
