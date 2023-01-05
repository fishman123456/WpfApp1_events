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

namespace WpfApp1_events
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

       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox1.Text = "Enter";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox1.Text = "esk";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_1(Button1, null);
            }
            else if (e.Key == Key.Escape)
            {
                Button_Click_2(Button2, null);
            }
        }



        //if (e.Key == Key.Enter)
        //{
        //    Button_Click_1(Button2, null);
        //}
        //else if (e.Key == Key.Escape)
        //{
        //    Button_Click(Button1, null);
        //}





    }
}
