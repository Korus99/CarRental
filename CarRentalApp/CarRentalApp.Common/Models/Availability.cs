using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Common.Models
{
    public class Availability
    {
        public int Id { get; set; }

        [Required] public int VehicleId { get; set; }

        public int UserId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Returned { get; set; }

        public DateTime ReturnedDate { get; set; }

        public int MaintenanceId { get; set; }
    }
}
