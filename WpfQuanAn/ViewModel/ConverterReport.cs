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
    public class ConverterReport : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (!string.IsNullOrEmpty(value.ToString()) && (int)value < 200000)
            {
                return new SolidColorBrush(Colors.Red);
            }
            else if (!string.IsNullOrEmpty(value.ToString()) && (int)value < 300000)
            {
                return Brushes.Yellow;
            }
            else
            {
                //return new SolidColorBrush(Colors.Red);
                return new SolidColorBrush(Colors.Green);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
