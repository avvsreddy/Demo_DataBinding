using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChangeNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Product p = new Product { ProductID = 101, ProductName = "Laptop", Price = 50000 };
            this.DataContext = p;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Product p = (Product)this.DataContext;
            p.Price += 1000;
            //p.ProductName = p.ProductName.ToUpper();
            MessageBox.Show("Product Price Changed");
        }
    }
}
