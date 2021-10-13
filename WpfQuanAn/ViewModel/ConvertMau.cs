using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfQuanAn.ViewModel
{
    public class ConvertMau : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty(value.ToString()) && value.ToString() == "0")
            {
                return new SolidColorBrush(Colors.Aqua);
               // return "../Assets/coffee_cup.png";
            }
            else
            {
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F7FE2E"));
                //return "../Assets/drink.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
