using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Угрюмова_практическая_6_ТРПО.Classes.Converters
{
    using System.Windows;
    using System.Windows.Data;
    using System.Web;
    using System.CodeDom;
    using System.Globalization;
    using Угрюмова_практическая_6_ТРПО.Classes.Converters;
    using Угрюмова_практическая_6_ТРПО.Classes;
    class DiscountToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targerType, object parameter, CultureInfo culture)
        {
            var hasDiscount = (bool)value;
            if (hasDiscount)
            {
                return Visibility.Visible;
            }
            else { return Visibility.Collapsed; }
        }
        public object ConvertBack(object value, Type targerType, object parameter, CultureInfo culture)
        {
            return (Visibility)value == Visibility.Visible;
        }
    }
}
