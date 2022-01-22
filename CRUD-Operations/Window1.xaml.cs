using System;
using System.Windows;
using System.Windows.Data;
using System.Data;

namespace CRUD_Operations
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    public partial class Window1 : Window
    {
        NorthwindDataSet ds = new NorthwindDataSet();
        NorthwindDataSetTableAdapters.EmployeesTableAdapter ta = new CRUD_Operations.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
        NorthwindDataSetTableAdapters.TableAdapterManager tam = new CRUD_Operations.NorthwindDataSetTableAdapters.TableAdapterManager();
        CollectionView view;
        public Window1()
        {
            InitializeComponent();
            ta.Fill(ds.Employees);
            DataContext = ds.Employees;
            view = (CollectionView)CollectionViewSource.GetDefaultView(ds.Employees); // for navigation
            tam.EmployeesTableAdapter = ta; //for save
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            view.MoveCurrentToFirst();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        { 
            if (view.CurrentPosition > 0)
            view.MoveCurrentToPrevious();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           if(view.CurrentPosition < view.Count -1)
            view.MoveCurrentToNext();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToLast();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Wish to delete this record ?", "Deleting", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var row = view.CurrentItem as DataRowView;
                row.Row.Delete();
            }

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            var row = ds.Employees.NewEmployeesRow();
            row.LastName = "[New]";
            row.FirstName = "[New]";
            //row.City = "[New]";

            ds.Employees.AddEmployeesRow(row);
            view.MoveCurrentToLast();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (ds.HasChanges())
            {
                if (MessageBox.Show("Do you wish to loose all your changes?", "Reverting", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    ds.RejectChanges();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (ds.HasChanges())
            {
                try
                {
                    if (tam.UpdateAll(ds) > 0)
                    {
                        MessageBox.Show("Saved changes");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
