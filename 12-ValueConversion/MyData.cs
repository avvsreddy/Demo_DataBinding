using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Data;

namespace _12_ValueConversion
{
    public class MyData
    {
        public MyData()
        {
            MyColor = "Red";
            MyOtherColor = System.Windows.Media.Colors.Green;
        }
        public string MyColor { get; set; }
        public System.Windows.Media.Color MyOtherColor { get; set; }
    }

    //[ValueConversion(typeof(Color),typeof(SolidColorBrush))]
    public class ColorBrushConvertor : System.Windows.Data.IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color color = (Color)value;
            return new SolidColorBrush(color);
            
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            SolidColorBrush brush = (SolidColorBrush)value;
            return brush.Color;
            
        }

        #endregion
    }
}
