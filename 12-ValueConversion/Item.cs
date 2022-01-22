using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace _12_ValueConversion
{
    public class Item
    {
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public Item()
        {
            ItemName="sdfsdfsdf";
            ItemPrice = 2342343.3434M;
        }
    }

    public class PriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            decimal price = (decimal)value;
            return price.ToString("C",culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

}
