using System.Windows;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Data;

namespace _14_SortingFiltering
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.DataContext = Process.GetProcesses();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string sortColumn = null;
            switch (comboBox1.Text)
            {
                case "Process Id":
                    sortColumn = "Id"; break;
                case "Process Name": sortColumn = "ProcessName"; break;
                case "Memory": sortColumn = "WorkingSet64"; break;
            }

            ListSortDirection sortDirection;
            if ((bool)radioButton1.IsChecked)
                sortDirection = ListSortDirection.Ascending;
            else
                sortDirection = ListSortDirection.Descending;
            
            listBox1.Items.SortDescriptions.Clear();
            listBox1.Items.SortDescriptions.Add(new SortDescription(sortColumn,sortDirection));
        }

       

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Filter = new System.Predicate<object> (Contains);

            //listBox1.Items.Filter = new System.Predicate<object>(obj => { return obj.ToString().Contains(textBox1.Text); });

            
        }

        private bool Contains(object obj)
        {
            string pname = obj.ToString();
            return pname.Contains(textBox1.Text);
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.GroupDescriptions.Add(new PropertyGroupDescription("PriorityClass"));
        }

       
    }
}
