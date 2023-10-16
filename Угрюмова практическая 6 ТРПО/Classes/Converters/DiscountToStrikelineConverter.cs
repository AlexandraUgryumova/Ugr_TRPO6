using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практическая_6_ТРПО.Classes.Converters
{
    using System.Windows.Data;
    using System.Windows;
    using System.Globalization;
    class DiscountToStrikelineConverter : IValueConverter
    {
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var decoration = value as TextDecoration;
            if (decoration != null)
            {
                return decoration.Location == TextDecorationLocation.Strikethrough;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool HasDiscount = (bool)value;
            if (HasDiscount)
            {
                return TextDecorations.Strikethrough;
            }
            else
            {
                return new TextDecoration();
            }
        }
    }
}
