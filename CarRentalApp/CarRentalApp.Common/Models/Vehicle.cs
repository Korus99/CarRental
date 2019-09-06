using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Common.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required] public string VIN { get; set; }

        public string Brand { get; set; }

        public string Make { get; set; }

        public string License { get; set; }

        public string State { get; set; }

        public int Mileage { get; set; }

        public bool Removed { get; set; }

        public string Location { get; set; }
    }
}
