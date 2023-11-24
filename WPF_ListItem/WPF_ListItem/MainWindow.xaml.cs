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
using WPF_ListItem.Data;

namespace WPF_ListItem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Person> People = new List<Person>()
        {
            new Person{Name="Brian", Age=30}, 
            new Person{Name="Jenny", Age=54},
            new Person{Name="May", Age=35},
            new Person{Name="Ali", Age=20},
            new Person{Name="Max", Age=10},
            
        };

        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach(Person person in selectedItems)
            {
                MessageBox.Show(person.Name);
            }
        }
    }
}
