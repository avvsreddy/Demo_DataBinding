using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;

namespace ChangeNotification
{
    public class Product:INotifyPropertyChanged
    {
        int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        int price;

        public int Price
        {
            get { return price; }
            set 
            {
                price = value;
                //OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                if(PropertyChanged !=null)
                    
                PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
       


        //public void OnPropertyChanged(PropertyChangedEventArgs e)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, e);
        //    }
        //}

    }
}
