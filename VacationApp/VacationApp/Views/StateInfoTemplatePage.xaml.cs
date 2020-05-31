using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VacationApp.ViewModels;
using VacationApp.Models;

namespace VacationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StateInfoTemplatePage : ContentPage
    {
        public StateInfoTemplatePage()
        {
            InitializeComponent();

            BindingContext = new StateInfoPageViewModel();
        }

        private void City1_Clicked(object sender, EventArgs e)
        {
            City1.BindingContext = new CityInfoViewModel()
            {
                DateImages = new List<DateImage>()
                {
                    new DateImage() { ImageSource = "uparrow.png", Date = "5/2/2020" },
                    new DateImage() { ImageSource = "downarrow.png", Date="5/6/2020" }
                }
            };
        }
    }
}