using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value;
                this.tbName.Foreground = Brushes.Red;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Value = "100";

            // MessageBox.Show("hello wpf!!!");
            //this.tbname.text = "jovan";
            //string username = this.tbname.text;
            //if (username == "jovan")
            //    this.tbname.foreground = brushes.orange;
            //  MessageBox.Show("确认通过");
            //this.tbName.Text = "Jovan";
        }
    }
}
