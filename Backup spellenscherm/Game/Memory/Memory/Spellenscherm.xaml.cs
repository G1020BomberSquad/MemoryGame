using SpellenScherm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Memory
{
    /// <summary>
    /// Interaction logic for Spellenscherm.xaml
    /// </summary>
    public partial class Spellenscherm : Window
    {
        private MemoryGrid grid;

        public Spellenscherm()
        {
            InitializeComponent();
            main = this;
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menuBar.Visibility = Visibility.Visible;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            grid = new MemoryGrid(GameGrid, 4, 4);
            start.Visibility = Visibility.Collapsed;
            turn1.Content = "Aan de beurt";
        }

        private void setNames_Click(object sender, RoutedEventArgs e)
        {
            string userName1 = nameEnter1.Text;
            string userName2 = nameEnter2.Text;

             MemoryGrid.player1 = userName1;
             MemoryGrid.player2 = userName2;

            name1.Content = userName1;
            name2.Content = userName2;
            set1.Visibility = Visibility.Collapsed;
            set2.Visibility = Visibility.Collapsed;
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You can't save your game yet.");
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You can't load a game yet.");
        }

        private void ResetGame_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void toMain_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A main screen has not been made yet.");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nl.wikipedia.org/wiki/Memory");
        }

        private void CloseMenuBar_Click(object sender, RoutedEventArgs e)
        {
            menuBar.Visibility = Visibility.Collapsed;
        }

        internal static Spellenscherm main;
        internal string Score1
        {
            get { return scoreName1.Content.ToString(); }
            set { Dispatcher.Invoke(new Action(() => { scoreName1.Content = value; })); }
        }

        internal string Score2
        {
            get { return scoreName2.Content.ToString(); }
            set { Dispatcher.Invoke(new Action(() => { scoreName2.Content = value; })); }
        }

        internal string setTurn1
        {
            get { return turn1.Content.ToString(); }
            set { Dispatcher.Invoke(new Action(() => { turn1.Content = value; })); }
        }

        internal string setTurn2
        {
            get { return turn2.Content.ToString(); }
            set { Dispatcher.Invoke(new Action(() => { turn2.Content = value; })); }
        }
    }
}
