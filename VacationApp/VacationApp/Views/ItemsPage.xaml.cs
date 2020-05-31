using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using VacationApp.Models;
using VacationApp.Views;
using VacationApp.ViewModels;
using Xamarin.Forms.Maps;

namespace VacationApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        private async void California_Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await Shell.Current.GoToAsync("//StateInfoPages/CaliforniaInfoPage");
        }

        private async void Nevada_Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await Shell.Current.GoToAsync("//StateInfoPages/NevadaInfoPage");
        }

        private async void Florida_Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await Shell.Current.GoToAsync("//StateInfoPages/FloridaInfoPage");
        }

        protected override void OnDisappearing()
        {
            mapmap.Pins[0].MarkerClicked -= Florida_Pin_MarkerClicked;
            mapmap.Pins[1].MarkerClicked -= California_Pin_MarkerClicked;
            mapmap.Pins[2].MarkerClicked -= Nevada_Pin_MarkerClicked;

            mapmap.Pins.Clear();

            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            var caliPin = new Pin() { Label = "California", Address = "The state of California.", Position = new Position(36.456636, -119.326283), Type = PinType.Generic };
            caliPin.MarkerClicked += California_Pin_MarkerClicked;
            var floridaPin = new Pin() { Label = "Florida", Address = "The state of Florida.", Position = new Position(39.571822, -116.886922), Type = PinType.Generic };
            floridaPin.MarkerClicked += Florida_Pin_MarkerClicked;
            var nevadaPin = new Pin() { Label = "Nevada", Address = "The state of Nevada.", Position = new Position(28.381735, -81.779204), Type = PinType.Generic };
            nevadaPin.MarkerClicked += Nevada_Pin_MarkerClicked;

            mapmap.Pins.Add(floridaPin);
            mapmap.Pins.Add(caliPin);
            mapmap.Pins.Add(nevadaPin);

            base.OnAppearing();
        }
    }
}