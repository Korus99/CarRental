using System;
using System.Collections.Generic;
using System.ComponentModel;
using CarRentalApp.Common.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarRentalApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewVehiclePage : ContentPage
    {
        public Vehicle Vehicle { get; set; }

        public NewVehiclePage()
        {
            InitializeComponent();

            Vehicle = new Vehicle();

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Vehicle);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}