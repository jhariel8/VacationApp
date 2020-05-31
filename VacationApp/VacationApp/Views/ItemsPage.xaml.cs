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
            //await Shell.Current.GoToAsync("///StateInfo");
        }

        private async void Nevada_Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            //await Shell.Current.GoToAsync("///StateInfo");
        }

        private async void Florida_Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await Shell.Current.GoToAsync("FloridaInfoPage");
        }
    }
}