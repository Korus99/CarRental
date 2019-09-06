using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CarRentalApp.Common.Models;
using CarRentalApp.Views;

namespace CarRentalApp.ViewModels
{
    public class VehicleViewModel : BaseViewModel
    {
        public ObservableCollection<Vehicle> Vehicles { get; set; }
        public Command LoadItemsCommand { get; set; }

        public VehicleViewModel()
        {
            Title = "Vehicle Inventory";
            Vehicles = new ObservableCollection<Vehicle>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewVehiclePage, Vehicle>(this, "AddItem", async (obj, vehicle) =>
            {
                var newVehicle = vehicle;
                Vehicles.Add(newVehicle);
                await DataStore.AddItemAsync(newVehicle);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Vehicles.Clear();
                var vehicles = await DataStore.GetItemsAsync(true);
                foreach (var vehicle in vehicles)
                {
                    Vehicles.Add(vehicle);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}