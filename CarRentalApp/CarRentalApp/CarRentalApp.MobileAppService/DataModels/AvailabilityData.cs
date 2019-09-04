using System;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class AvailabilityData
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Returned { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public int? MaintenanceId { get; set; }

        public virtual MaintenanceData Maintenance { get; set; }
        public virtual UserData User { get; set; }
        public virtual VehicleData Vehicle { get; set; }
    }
}
