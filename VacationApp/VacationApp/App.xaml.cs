using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VacationApp.Services;
using VacationApp.Views;

namespace VacationApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            Routing.RegisterRoute("FloridaInfoPage", typeof(FloridaInfoPage));
            Routing.RegisterRoute("CaliforniaInfoPage", typeof(CaliforniaInfoPage));
            Routing.RegisterRoute("NevadaInfoPage", typeof(NevadaInfoPage));
 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
