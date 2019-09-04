using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalApp.MobileAppService.DataModels;

namespace CarRentalApp.MobileAppService
{
    public static class Convert
    {
        public static VehicleData ToDataModel(Models.Vehicle vehicle)
        {
            return new VehicleData()
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Make = vehicle.Make,
                License = vehicle.License,
                Location = vehicle.Location,
                Mileage = vehicle.Mileage,
                Removed = vehicle.Removed,
                State = vehicle.State,
                Vin = vehicle.VIN
            };
        }

        public static Models.Vehicle FromDataModel(VehicleData vehicle)
        {
            return new Models.Vehicle()
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Make = vehicle.Make,
                License = vehicle.License,
                Location = vehicle.Location,
                Mileage = vehicle.Mileage,
                Removed = vehicle.Removed,
                State = vehicle.State,
                VIN = vehicle.Vin
            };
        }
    }
}
