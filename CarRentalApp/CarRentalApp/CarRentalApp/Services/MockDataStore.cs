using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalApp.Common.Models;

namespace CarRentalApp.Services
{
    public class MockDataStore : IDataStore<Vehicle>
    {
        List<Vehicle> vehicles;

        public MockDataStore()
        {
            vehicles = new List<Vehicle>();
            var id = 1;
            var mockItems = new List<Vehicle>
            {
                new Vehicle {Id = id++, VIN = "5TDKK3DC9BS133106", Brand = "AutoMaker", Make = "A1"},
                new Vehicle {Id = id++, VIN = "1GJHG35K591104946", Brand = "TruckMaker", Make = "T1"},
                new Vehicle {Id = id++, VIN = "1FMNU43S3YEC81896", Brand = "AutoMaker", Make = "A1"},
                new Vehicle {Id = id++, VIN = "4V4LC9KK37N405827", Brand = "TruckMaker", Make = "T1"},
                new Vehicle {Id = id++, VIN = "2FTEF15Y2GCB10186", Brand = "AutoMaker", Make = "A3"},
                new Vehicle {Id = id++, VIN = "WMWZC3C58FWT14974", Brand = "AutoMaker", Make = "A2"}
            };

            foreach (var vehicle in mockItems)
            {
                vehicles.Add(vehicle);
            }
        }

        public async Task<bool> AddItemAsync(Vehicle vehicle)
        {
            vehicles.Add(vehicle);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Vehicle vehicle)
        {
            var oldItem = vehicles.Where((Vehicle arg) => arg.Id == vehicle.Id).FirstOrDefault();
            vehicles.Remove(oldItem);
            vehicles.Add(vehicle);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = vehicles.FirstOrDefault(arg => arg.Id == id);
            vehicles.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Vehicle> GetItemAsync(int id)
        {
            return await Task.FromResult(vehicles.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Vehicle>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(vehicles);
        }
    }
}