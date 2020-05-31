using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace VacationApp.Views.Converter
{
    public class DictionaryToImageSourceConverter : BindableObject, IValueConverter
    {
        public static readonly BindableProperty CityNameProperty = BindableProperty.Create("CityName", typeof(string), typeof(DictionaryToImageSourceConverter), string.Empty);

        public string CityName
        {
            get { return (string)GetValue(CityNameProperty);  }
            set { SetValue(CityNameProperty, value);  }
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dictionary = value as Dictionary<string, List<Image>>;

            return dictionary[CityName];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
