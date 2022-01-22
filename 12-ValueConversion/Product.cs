using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace _12_ValueConversion
{
    public class Product
    {
        public Product()
        {
            ProductName = "Laptop";
            InStock = 0; // 1:yes, 0:No
        }
        public string ProductName { get; set; }
        public int InStock { get; set; }
    }

    //public class StockConvertor : System.Windows.Data.IValueConverter
    //{
    //    #region IValueConverter Members

    //    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        int intValue = (int)value;
    //        return (intValue == 1)?true:false;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        bool IsInStock = (bool)value;
    //        return (IsInStock) ? 1 : 0;
    //        // return null;
    //    }

    //    #endregion
    //}

}
