using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using System.ComponentModel;

namespace XmlDataBindingEmployees
{
    /// <summary>
    /// Interaction logic for frmObjectDataBinding.xaml
    /// </summary>

    public partial class frmObjectDataBinding : System.Windows.Window
    {

        public frmObjectDataBinding()
        {
            InitializeComponent();
        }

    }



    //Class for Performance Counter using Dependency Object

  /*  public class Processor : DependencyObject
    {
        private PerformanceCounter pc = null;
        private DispatcherTimer tmr = new DispatcherTimer();

        public static DependencyProperty ProcessorTimeProperty =
       DependencyProperty.Register("ProcessorTime", typeof(float), typeof(Processor));


        private float procTime;

        public Processor()
        {
            pc = new PerformanceCounter("Processor","% Processor Time");
            pc.InstanceName = "_Total";
            tmr.Interval = TimeSpan.FromSeconds(1);
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.IsEnabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            procTime = pc.NextValue();
            //System.Diagnostics.Debug.WriteLine("............." + procTime);

        }
        public float ProcessorTime
        {
            get 
            {
                return (float)GetValue(ProcessorTimeProperty);
            }
            set
            {
                SetValue(ProcessorTimeProperty, value);
            }

        }

    }*/
    public class Processor : INotifyPropertyChanged
    {
        private PerformanceCounter pc = null;
        private DispatcherTimer tmr = new DispatcherTimer();
        private float procTime;

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public float ProcessorTime
        {
            get { return procTime; }
        }

        public Processor()
        {
            pc = new PerformanceCounter("Processor", "% Processor Time");
            pc.InstanceName = "_Total";
            tmr.Interval = TimeSpan.FromSeconds(1);
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.IsEnabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            procTime = pc.NextValue();
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("ProcessorTime"));
        }
    }

    //This approach has two oustanding advantages:

//- If you had multiple values to reflect (say databinding using DataContext), this approach is much more convenient.
//- Secondly, your business objects, don't inherit from DependencyObject, which makes them, so darned much easier to use.


}