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

namespace WPF_Checkbox
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

        private void AllToppings_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = AllToppings.IsChecked == true;
            Salami.IsChecked = newVal;
            Mushrooms.IsChecked = newVal;
            Cheeze.IsChecked = newVal;
        }

        private void Single_Checked(object sender, RoutedEventArgs e)
        {
            AllToppings.IsChecked = null;
            if((Salami.IsChecked == true) && (Mushrooms.IsChecked == true) && (Cheeze.IsChecked == true)){
                AllToppings.IsChecked = true;
            }

            if ((Salami.IsChecked == false) && (Mushrooms.IsChecked == false) && (Cheeze.IsChecked == false))
            {
                AllToppings.IsChecked = false;
            }
        }
    }
}
