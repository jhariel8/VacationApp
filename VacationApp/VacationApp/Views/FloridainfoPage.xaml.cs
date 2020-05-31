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
    public partial class FloridainfoPage  : ContentPage
    {
        public FloridainfoPage()
        {
            InitializeComponent();

            BindingContext = new StateInfoPageViewModel();

            placeholderLabel.IsVisible = true;
        }

        private void City1_Clicked(object sender, EventArgs e)
        {
            City1.BindingContext = new CityInfoViewModel()
            {
                DateImages = new List<DateImage>()
                {
                    new DateImage() { ImageSource = "Orlando_May29th_2020.jpg", Date = "5/29/2020" },
                    new DateImage() { ImageSource = "Orlando_May8th_2020.jpg", Date = "5/8/2020" },
                    new DateImage() { ImageSource = "Orlando_April17th_2020.jpg", Date = "4/17/2020" },
                    new DateImage() { ImageSource = "Orlando_April17th_2019.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "Orlando_March27th_2020.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "Orlando_Feb27th_2020.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "Orlando_Jan27th_2020.jpg", Date = "1/27/2020" }


                },
                CityName = "Orlando"
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
                    new DateImage() { ImageSource = "Miami_May29th_2020.jpg", Date = "5/29/2020" },
                    new DateImage() { ImageSource = "Miami_May8th_2020.jpg", Date = "5/8/2020" },
                    new DateImage() { ImageSource = "Miami_April17th_2020.jpg", Date = "4/17/2020" },
                    new DateImage() { ImageSource = "Miami_April17th_2019.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "Miami_March27th_new2020.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "Miami_Feb27th_new2020.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "Miami_Jan27th_new2020.jpg", Date = "1/27/2020" }
                }
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
                    new DateImage() { ImageSource = "tampa_may29th_2020.jpg", Date = "5/29/2020" },
                    new DateImage() { ImageSource = "tampa_may8th_2020.jpg", Date = "5/8/2020" },
                    new DateImage() { ImageSource = "tampa_april17th_2020.jpg", Date = "4/17/2020" },
                    new DateImage() { ImageSource = "Tampa_april17th_2019.jpg", Date = "4/17/2019" },
                    new DateImage() { ImageSource = "tampa_march27th_2020.jpg", Date = "3/27/2020" },
                    new DateImage() { ImageSource = "tampa_feb27th_2020.jpg", Date = "2/27/2020" },
                    new DateImage() { ImageSource = "tampa_Jan27th_2020.jpg", Date = "1/27/2020" }
                }
            };

            City1.IsVisible = false;
            City2.IsVisible = false;
            City3.IsVisible = true;
            placeholderLabel.IsVisible = false;
        }
    }
}