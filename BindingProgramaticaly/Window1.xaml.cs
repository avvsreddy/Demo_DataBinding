using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BindingProgramaticaly
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            Binding b = new Binding();
            b.ElementName = "textBox1";//Source
            b.Path = new PropertyPath("Text");

            textBox2.SetBinding(TextBox.TextProperty, b);//target
        }
    }
}
