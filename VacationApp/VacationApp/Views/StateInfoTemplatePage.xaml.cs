using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VacationApp.ViewModels;

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
    }
}