using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.MobileAppService.Models
{
    public class Maintenance
    {
        public int Id { get; set; }

        [Required] public int VehicleId { get; set; }

        [Required] public int MaintenanceId { get; set; }

        public DateTime MaintenanceStart { get; set; }

        public DateTime MaintenanceEnd { get; set; }

        public bool Completed { get; set; }

        public int CompletedBy { get; set; }
    }
}
