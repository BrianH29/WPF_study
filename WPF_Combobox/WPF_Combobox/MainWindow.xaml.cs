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

namespace WPF_Combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // BH - you could get a whole list of colors
            //comboBoxColors.ItemsSource = typeof(Colors).GetProperties();

            // BH - just option of my own 
            List<Colors> colors = new List<Colors>();
            colors.Add(new Colors() { ColorName = "red"});
            colors.Add(new Colors() { ColorName = "blue"});
            colors.Add(new Colors() { ColorName = "yellow"});

            comboBoxColors.ItemsSource = colors;
        }
    }

    public class Colors
    {
        public string ColorName { get; set; }
    }
     
}
