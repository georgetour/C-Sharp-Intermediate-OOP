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

namespace Downcasting_Example
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Downcasting
            //Now we will have access to all properties of Button class
            //var button = (Button)sender;


            //And more safer by using the as keyword
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());

            }
            
            MessageBox.Show("Hello World");
        }
    }
}
