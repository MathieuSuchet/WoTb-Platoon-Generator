using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using WotGenC.Modes;

namespace GénérateurWot.Converters
{
    public class StringToModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Mode)value)?.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((MainWindow)parameter)?.Modes.Where(x => x.Name == (string)value);
        }
    }
}