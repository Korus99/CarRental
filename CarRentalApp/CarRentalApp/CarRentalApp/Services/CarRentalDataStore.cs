using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using CarRentalApp.Common.Models;

namespace CarRentalApp.Services
{
    public class CarRentalDataStore : IDataStore<Vehicle>
    {
        HttpClient client;
        IEnumerable<Vehicle> _vehicles;

        public CarRentalDataStore()
        {
            client = new HttpClient {BaseAddress = new Uri($"{App.AzureBackendUrl}/")};

            _vehicles = new List<Vehicle>();
        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        public async Task<IEnumerable<Vehicle>> GetItemsAsync(bool forceRefresh = false)
        {
            if (!forceRefresh || !IsConnected) return _vehicles;

            var json = await client.GetStringAsync($"api/Vehicle");
            _vehicles = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Vehicle>>(json));

            return _vehicles;
        }

        public async Task<Vehicle> GetItemAsync(int id)
        {
            if (id == 0 || !IsConnected) return null;

            var json = await client.GetStringAsync($"api/vehicle/{id}");
            return await Task.Run(() => JsonConvert.DeserializeObject<Vehicle>(json));
        }

        public async Task<bool> AddItemAsync(Vehicle vehicle)
        {
            if (vehicle == null || !IsConnected)
                return false;

            var serializedVehicle = JsonConvert.SerializeObject(vehicle);

            var response = await client.PostAsync($"api/vehicle", new StringContent(serializedVehicle, Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemAsync(Vehicle vehicle)
        {
            if (vehicle == null || vehicle.Id == 0 || !IsConnected)
                return false;

            var serializedVehicle = JsonConvert.SerializeObject(vehicle);
            var buffer = Encoding.UTF8.GetBytes(serializedVehicle);
            var byteContent = new ByteArrayContent(buffer);

            var response = await client.PutAsync(new Uri($"api/vehicle/{vehicle.Id}"), byteContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            if (id == 0 && !IsConnected)
                return false;

            var response = await client.DeleteAsync($"api/vehicle/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
