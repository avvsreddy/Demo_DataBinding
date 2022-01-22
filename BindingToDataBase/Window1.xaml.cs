using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Data;

namespace BindingToDataBase
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        CollectionView view;
        #region DataSet
        //NorthwindDataSet ds = new NorthwindDataSet();
        //NorthwindDataSetTableAdapters.EmployeesTableAdapter ta = new BindingToDataBase.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
        //NorthwindDataSetTableAdapters.TableAdapterManager tam = new BindingToDataBase.NorthwindDataSetTableAdapters.TableAdapterManager();
        #endregion
 
        NorthwindDataContext db;


        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new NorthwindDataContext();
            DataContext = db.Employees.AsQueryable<Employee>();//.ToList<Employee>();
            view = (CollectionView)CollectionViewSource.GetDefaultView(DataContext);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToNext();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToPrevious();
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //Save
                       
            db.SubmitChanges();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
            //var ee = view.CurrentItem as Employee;
            Employee ee;
            ee = new Employee {EmployeeID=111,FirstName="New",LastName="New" };
            db.Employees.InsertOnSubmit(ee);
            
            //db.SubmitChanges();
            view.Refresh();

            view.MoveCurrentToLast();

        }

        
    }
}
