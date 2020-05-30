using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VacationApp.ViewModels
{
    public class StateInfoPageViewModel : BaseViewModel
    {
       public ICommand GoToCaseCountCommand 
       { 
            get
            {
                return new Command<string>(async (string url) =>
                {
                    await Browser.OpenAsync(new Uri(url));
                });
            } 
       }
    }
}
