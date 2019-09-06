using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalApp.Common.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CarRentalApp.Views;
using CarRentalApp.ViewModels;

namespace CarRentalApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class VehiclesPage : ContentPage
    {
        VehicleViewModel viewModel;

        public VehiclesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new VehicleViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Vehicle vehicle))
                return;

            await Navigation.PushAsync(new VehicleDetailPage(new VehicleDetailViewModel(vehicle)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewVehiclePage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Vehicles.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}