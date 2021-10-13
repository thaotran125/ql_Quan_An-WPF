using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfQuanAn.ViewModel
{
    public class ConvvertImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty(value.ToString()) && value.ToString() == "0")
            {
                //return new SolidColorBrush(Colors.Black);
                return "../Assets/coffee_cup.png";
            }
            else
            {
                //return new SolidColorBrush(Colors.Red);
                return "../Assets/drink.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
