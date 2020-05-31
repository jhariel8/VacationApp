using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VacationApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CityInfoView : ContentView
    {
        public static readonly BindableProperty CityNameProperty = BindableProperty.Create("CityName", typeof(string), typeof(CityInfoView), string.Empty);
        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create("Description", typeof(string), typeof(CityInfoView), "Scroll through the photos to see the changes in activity before and during the COVID-19 pandemic. Places with large spikes in activity should probably be avoided.");

        public string CityName
        {
            get { return (string)GetValue(CityNameProperty); }
            set { SetValue(CityNameProperty, value); }
        }

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public CityInfoView()
        {
            InitializeComponent();
        }
    }
}