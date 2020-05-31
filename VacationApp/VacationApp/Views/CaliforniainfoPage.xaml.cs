using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VacationApp.ViewModels;
using VacationApp.Models;
using VacationApp.Services;

namespace VacationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaliforniainfoPage  : ContentPage
    {
        private readonly IRequestService requestService;
        bool timerShouldContinue = true;

        public CaliforniainfoPage()
        {
            InitializeComponent();

            BindingContext = new StateInfoPageViewModel();

            placeholderLabel.IsVisible = true;

            requestService = DependencyService.Get<IRequestService>();

            UpdateCount();

            Device.StartTimer(TimeSpan.FromSeconds(3), UpdateCount);
        }

        private void City1_Clicked(object sender, EventArgs e)
        {
            City1.BindingContext = new CityInfoViewModel()
            {
                DateImages = new List<DateImage>()
                {
                    new DateImage() { ImageSource = "1-27-20.jpg", Date = "1/27/2020" },
                    new DateImage() { ImageSource = "2-27-20.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "3-27-20.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "4-17-19.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "la_gif.gif", Date = string.Empty }
                   


                },
                CityName = "Los Angeles"
            };

            City1.IsVisible = true;
            City2.IsVisible = false;
            City3.IsVisible = false;
            placeholderLabel.IsVisible = false;
        }

        private void City2_Clicked(object sender, EventArgs e)
        {
            City2.BindingContext = new CityInfoViewModel()
            {
                DateImages = new List<DateImage>()
                {
                    new DateImage() { ImageSource = "SD_1-27-20.jpg", Date = "1/27/2020" },
                    new DateImage() { ImageSource = "SD_2-27-20.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "SD_3-27-20.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "SD_4-17-19.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "sd_GIF.gif", Date = string.Empty }
                },
                CityName = "San Diego"

            };

            City1.IsVisible = false;
            City2.IsVisible = true;
            City3.IsVisible = false;
            placeholderLabel.IsVisible = false;
        }

        private void City3_Clicked(object sender, EventArgs e)
        {
            City3.BindingContext = new CityInfoViewModel()
            {
                DateImages = new List<DateImage>()
                {
                    new DateImage() { ImageSource = "sac_1-27-20.jpg", Date = "1/27/2020" },
                    new DateImage() { ImageSource = "Sac_2-27-20.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "sac_3-27-20.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "Sac_4-17-19.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "sac_GIF.gif", Date = string.Empty }
                },
                CityName = "Sacramento"
            };

            City1.IsVisible = false;
            City2.IsVisible = false;
            City3.IsVisible = true;
            placeholderLabel.IsVisible = false;
        }

        private bool UpdateCount()
        {
            Task.Run(async () =>
            {
                string caseCount = await requestService.ReadCaseCountByState("CA");
                Device.BeginInvokeOnMainThread(() => liveCaseCount.Text = "Live Case Count: " + caseCount);
            });
            return timerShouldContinue;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            timerShouldContinue = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            timerShouldContinue = false;
        }
    }
}