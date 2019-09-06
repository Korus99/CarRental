using System;
using CarRentalApp.Common.Models;

namespace CarRentalApp.ViewModels
{
    public class VehicleDetailViewModel : BaseViewModel
    {
        public Vehicle Vehicle { get; set; }
        public VehicleDetailViewModel(Vehicle vehicle = null)
        {
            Title = vehicle.VIN;
            Vehicle = vehicle;
        }
    }
}
