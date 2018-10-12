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

namespace SpellenScherm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MemoryGrid grid;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            grid = new MemoryGrid(GameGrid, 4, 4);
        }

        private void insertName1_Click(object sender, RoutedEventArgs e)
        {           
            string userName1 = nameEnter1.Text;
            name1.Content = userName1;
        }

        private void insertName2_Click(object sender, RoutedEventArgs e)
        {
            string userName2 = nameEnter2.Text;
            name2.Content = userName2;
        }
    }
}
