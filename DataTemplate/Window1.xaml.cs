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

namespace DataTemplate
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Person> people = new List<Person>();

        public Window1()
        {
            InitializeComponent();

            people.Add(new Person("Venkat", 36, "1.jpg"));
            people.Add(new Person("Reddy", 10, "2.jpg"));

            MyGrid.DataContext = people;
        }
    }

    
}
