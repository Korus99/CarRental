using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CarRentalApp.Common.Models;
using CarRentalApp.ViewModels;

namespace CarRentalApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class VehicleDetailPage : ContentPage
    {
        VehicleDetailViewModel viewModel;

        public VehicleDetailPage(VehicleDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public VehicleDetailPage()
        {
            InitializeComponent();

            var vehicle = new Vehicle
            {
                VIN = "2",
                Brand = "T1"
            };

            viewModel = new VehicleDetailViewModel(vehicle);
            BindingContext = viewModel;
        }
    }
}