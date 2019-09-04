using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.MobileAppService.Models
{
    public class MaintenanceSchedule
    {
        public int Id { get; set; }

        [Required] public int VehicleId { get; set; }

        [Required] public string Maintenance { get; set; }

        public DateTime DueDate { get; set; }

        public bool Recurring { get; set; }

        public TimeSpan NextDate { get; set; }

        public int NextMile { get; set; }
    }
}
