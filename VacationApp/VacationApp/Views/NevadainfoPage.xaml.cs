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
    public partial class NevadainfoPage : ContentPage
    {
        private readonly IRequestService requestService;
        bool timerShouldContinue = true;

        public NevadainfoPage()
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
                    new DateImage() { ImageSource = "LasV_May29TH_2020.jpg", Date = "5/29/2020" },
                    new DateImage() { ImageSource = "LasV_May8th_2020.jpg", Date="5/8/2020" },
                    new DateImage() { ImageSource = "LasV_April17th_2020.jpg", Date = "4/17/2020" },
                    new DateImage() { ImageSource = "LasV_April17_2019.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "LasV_March27th_2020.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "LasV_Feb27th_2020.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "LasV_Jan27th_2020.jpg", Date = "1/27/2020" }
                },
                CityName = "Las Vegas"
            };

            City1.IsVisible = true;
            City2.IsVisible = false;
            placeholderLabel.IsVisible = false;
        }

        private void City2_Clicked(object sender, EventArgs e)
        {
            City2.BindingContext = new CityInfoViewModel()
            {
                DateImages = new List<DateImage>()
                {
                    new DateImage() { ImageSource = "Reno_May29TH_2020.jpg", Date = "5/29/2020" },
                    new DateImage() { ImageSource = "Reno_May8th_2020.jpg", Date="5/8/2020" },
                    new DateImage() { ImageSource = "Reno_April17th_2020.jpg", Date = "4/17/2020" },
                    new DateImage() { ImageSource = "Reno_April17th_2019.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "Reno_March27th_2020.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "Reno_Feb27th_2020.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "Reno_Jan27th_2020.jpg", Date = "1/27/2020" }
                    
                },
                CityName = "Reno"
            };

            City1.IsVisible = false;
            City2.IsVisible = true;
            placeholderLabel.IsVisible = false;
        }

        private bool UpdateCount()
        {
            Task.Run(async () =>
            {
                string caseCount = await requestService.ReadCaseCountByState("NV");
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