﻿using System.Collections.Generic;
using System.Linq;
using CarRentalApp.Common.Models;
using CarRentalApp.MobileAppService.Common;
using CarRentalApp.MobileAppService.DataModels;
using CarRentalApp.MobileAppService.Repository.Interface;

namespace CarRentalApp.MobileAppService.Business
{
    public class VehicleBusiness : IVehicleBusiness
    {
        public VehicleBusiness()
        {

        }

        public IEnumerable<Vehicle> GetAll()
        {
            using (var context = new CarRentalContext())
            {
                var vehicles = context.Vehicle.ToList();
                foreach (var vehicle in vehicles)
                {
                    yield return Convert.FromDataModel(vehicle);
                }
            }
        }

        public void Add(Vehicle vehicle)
        {
            using (var context = new CarRentalContext())
            {
                var newVehicle = Convert.ToDataModel(vehicle);
                context.Vehicle.Add(newVehicle);
                context.SaveChanges();
            }
        }

        public Vehicle Get(int id)
        {
            using (var context = new CarRentalContext())
            {
                var vehicle = context.Vehicle.Single(v => v.Id == id);
                return Convert.FromDataModel(vehicle);
            }
        }

        public Vehicle Remove(int id)
        {
            using (var context = new CarRentalContext())
            {
                var vehicle = context.Vehicle.Single(v => v.Id == id);
                vehicle.Removed = true;
                context.SaveChanges();

                return Convert.FromDataModel(vehicle);
            }
        }

        public void Update(Vehicle vehicle)
        {
            using (var context = new CarRentalContext())
            {
                var updateVehicle = context.Vehicle.Single(v => v.Id == vehicle.Id);
                updateVehicle = Convert.ToDataModel(vehicle);
                context.SaveChanges();
            }
        }
    }
}
