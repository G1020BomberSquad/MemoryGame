using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SpellenScherm
{
     public class MemoryGrid
    {
        private Grid grid;
        private int rows, cols;
        private object game_grid;

        public MemoryGrid(Grid grid, int rows, int cols)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;

            InitializeGrid();
            AddImages();
        }


        private void InitializeGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < cols; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void AddImages()
        {
            List<ImageSource> images = GetImagesList();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Image back = new Image();
                    back.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));

                    // klik op image = omdraaien
                    back.MouseDown += new System.Windows.Input.MouseButtonEventHandler(CardClick);

                    back.Tag = images.First();
                    images.RemoveAt(0);

                    Grid.SetColumn(back, col);
                    Grid.SetRow(back, row);
                    grid.Children.Add(back);
                }
            }

        }

        private void checkPoint()
        {

        }

        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
        }

        private List<ImageSource> GetImagesList()
        {
            List<ImageSource> images = new List<ImageSource>();

            for (int i = 0; i < 16; i++)
            {
                int imageNR = i % 8 + 1;
                ImageSource source = new BitmapImage(new Uri("images/" + imageNR + ".png", UriKind.Relative));
                images.Add(source);
            }

            return images;
        }

    }
}
