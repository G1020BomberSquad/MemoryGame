using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SpellenScherm
{
    public class MemoryGrid
    {
        // defines the grid
        private Grid grid;

        // creates 2 players
        public static string player1 { get; set; }
        public static string player2 { get; set; }

        // define the number of rows and cols
        private int rows, cols;

        // variable for the number of clicks
        static int numberOfClicks = 0;

        // the total scores which will be displayed to the players
        static int scoreName1Tot;
        static int scoreName2Tot;

        // variables to count if there is made a new point, and to make it easier to keep track of the turns
        static int scoreName1;
        static int scoreName2;

        // a variable to count the number of pairs, and to know when the game is over
        static int numberOfPairs;

        // a bool to check if the game needs to wait and if currently waiting
        private bool hasDelay;

        // bools that control the turns
        private bool turnName1 = true;
        private bool turnName2 = false;

        // Images the are displayed
        private Image card;
        private Image Image1;
        private Image Image2;

        /// <summary>
        /// Initialize the grid and assign the images to the grid
        /// </summary>
        /// <param name="grid">Defines the grid</param>
        /// <param name="rows">How many rows there are</param>
        /// <param name="cols">How many cols there are</param>
        public MemoryGrid(Grid grid, int rows, int cols)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;

            InitializeGrid();
            AddImages();
        }

        /// <summary>
        /// Initialises the GameGrid
        /// </summary>
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

        /// <summary>
        /// Adds images to the grid
        /// </summary>
        private void AddImages()
        {
            List<ImageSource> images = GetImagesList();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // assign the back of the image
                    Image back = new Image();
                    back.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));

                    // when one of the players click on a card
                    back.MouseDown += new System.Windows.Input.MouseButtonEventHandler(CardClick);

                    // set the cards
                    back.Tag = images.First();
                    images.RemoveAt(0);
                    Grid.SetColumn(back, col);
                    Grid.SetRow(back, row);
                    grid.Children.Add(back);
                }
            }
        }

        /// <summary>
        /// Give each card a random image
        /// </summary>
        /// <returns>Return the images</returns>
        public List<ImageSource> GetImagesList()
        {
            // a list that holds the images
            List<ImageSource> images = new List<ImageSource>();

            // two lists that keep track of the used images, so there are only 2 cards of the sort
            List<string> random1 = new List<string>();
            List<string> random2 = new List<string>();


            // randomizer
            for (int i = 0; i < 16; i++)
            {
                if (i < 8)
                {
                    // a variable that represents the image that is going to be used
                    int imageNR = 0;

                    // generate a random int between 1 and 8
                    Random rnd = new Random();
                    imageNR = rnd.Next(1, 9);

                    // if the genrated number already exists (in the list 'random1'), generate a new number
                    if (random1.Contains(Convert.ToString(imageNR)))
                    {
                        i--;
                    }
                    // if the generated number does not exists (in the list 'random1'), grab the image with that number
                    else
                    {
                        random1.Add(Convert.ToString(imageNR));
                        ImageSource source = new BitmapImage(new Uri("images/" + imageNR + ".png", UriKind.Relative));
                        images.Add(source);
                    }
                }
                if (i >= 8)
                {
                    // a variable that represents the image that is going to be used
                    int imageNR = 0;

                    // generate a random int between 1 and 8
                    Random rnd = new Random();
                    imageNR = rnd.Next(1, 9);

                    // if the genrated number already exists (in the list 'random2'), generate a new number
                    if (random2.Contains(Convert.ToString(imageNR)))
                    {
                        i--;
                    }
                    // if the generated number does not exists (in the list 'random2'), grab the image with that number
                    else
                    {
                        random2.Add(Convert.ToString(imageNR));
                        ImageSource source = new BitmapImage(new Uri("images/" + imageNR + ".png", UriKind.Relative));
                        images.Add(source);
                    }
                }
            }
            return images;
        }

        /// <summary>
        /// Turns the card when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            // wait with showing the card if this is true, the previous turn needs to finish first
            if (hasDelay) return;

            // if the game does not have to wait, show the card
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
            numberOfClicks++;

            checkCards(card);
        }

        /// <summary>
        /// Shows who's turn it is under the players name
        /// </summary>
        private void showTurn()
        {
            // if its player1's turn, show 'Aan de beurt' under their name
            if (turnName1 == true)
            {
                Spellenscherm.main.setTurn1 = "Aan de beurt";
                Spellenscherm.main.setTurn2 = "";

            }
            // if its player2's turn, show 'Aan de beurt' under their name
            else if (turnName2 == true)
            {
                Spellenscherm.main.setTurn1 = "";
                Spellenscherm.main.setTurn2 = "Aan de beurt";
            }
        }

        /// <summary>
        /// Grab the clicked card
        /// </summary>
        /// <param name="card">The card that has been clicked</param>
        private void checkCards(Image card)
        {
            this.card = card;

            // card the cards that have been clicked
            if (numberOfClicks < 2 || numberOfClicks == 2)
            {

                if (this.Image1 == null)
                {
                    Image1 = card;
                }
                else if (this.Image2 == null)
                {
                    Image2 = card;
                }
            }

            // when to cards have been clicked, check if they are a pair
            if (numberOfClicks == 2)
            {
                checkPair(Image1, Image2);

                // reset the variables for the next turn
                numberOfClicks = 0;
                Image1 = null;
                Image2 = null;
            }
        }

        /// <summary>
        /// Check if the two clicked cards have the same image (source)
        /// </summary>
        /// <param name="card1">The first card that has been clicked</param>
        /// <param name="card2">The second card that has been clicked</param>
        public void checkPair(Image card1, Image card2)
        {
            this.Image1 = card1;
            this.Image2 = card2;

            // if 2 images are clicked, there are the same and the same card is not clicked twice
            if (Convert.ToString(card1.Source) == Convert.ToString(card2.Source) && (card1 != card2))
            {
                getPoint(card1, card2);
            }
            // if 2 images are clicked, they are not the same and the same card is not clicked twice
            else
            {
                resetCards(Image1, Image2);
            }   

            checkTurn();

            // if the clicked card is clicked twice, the player keeps their turn
            if (Convert.ToString(card1.Source) == Convert.ToString(card2.Source) && (card1 == card2))
            {
                stayTurn();
            }

            updateScore();

            // if all the pair have been found
            if (numberOfPairs == 8)
            {
                checkWinner();
            }

            // reset the variables for the next turn
            scoreName1 = 0;
            scoreName2 = 0;
            showTurn();
        }

        /// <summary>
        /// Gives turns
        /// </summary>
        private void checkTurn()
        {
            // check if its player1's turn
            if (turnName1 == true)
            {
                // if player 1 has a point, they keep their turn and their score increases with one
                if (scoreName1 == 1)
                {
                    scoreName1Tot = scoreName1 + scoreName1Tot;
                }
                // if player 1 does not have a point, they lose their turn and their score stays the same
                else if (scoreName1 == 0)
                {
                    turnName1 = false;
                    turnName2 = true;
                }
            }
            // check if its player2's turn
            else if (turnName2 == true)
            {
                // if player 2 has a point, they keep their turn and their score increases with one
                if (scoreName2 == 1)
                {
                    scoreName2Tot = scoreName2 + scoreName2Tot;
                }
                // if player 2 does not have a point, they lose their turn and their score stays the same
                else if (scoreName2 == 0)
                {
                    turnName2 = false;
                    turnName1 = true;
                }
            }
        }

        /// <summary>
        /// When the same card is doubleclicked, the turn is kept
        /// </summary>
        private void stayTurn()
        {
            // check if its player1's turn, give the turn to player 2
            if (turnName1 == true)
            {
                turnName1 = false;
                turnName2 = true;
            }
            // check if its player2's turn and give the turn to player 1
            else if (turnName1 == false)
            {
                turnName1 = true;
                turnName2 = false;
            }
        }

        /// <summary>
        /// Updates Score Labels
        /// </summary>
        private void updateScore()
        {
            Spellenscherm.main.Score1 = "Score: " + scoreName1Tot;
            Spellenscherm.main.Score2 = "Score: " + scoreName2Tot;
        }

        /// <summary>
        /// Give points and remove pairs from GameGrid
        /// </summary>
        /// <param name="card1">The first card that has been clicked</param>
        /// <param name="card2">The second card that has been clicked</param>
        private async void getPoint(Image card1, Image card2)
        {
            // if its player1's turn, increase their score
            if (turnName1 == true)
            {
                numberOfPairs++;
                scoreName1++;
            }
            // if its player2's turn, increase their score
            else if (turnName2 == true)
            {
                numberOfPairs++;
                scoreName2++;
            }

            // wait a third of a second, show the second card first
            hasDelay = true;
            await Task.Delay(300);

            // remove the cards from the board
            card1.Source = new BitmapImage(new Uri("", UriKind.Relative));
            card2.Source = new BitmapImage(new Uri("", UriKind.Relative));

            hasDelay = false;
        }

        /// <summary>
        /// Reset the cards
        /// </summary>
        /// <param name="card1">The first card that has been clicked</param>
        /// <param name="card2">The second card that has been clicked</param>
        private async void resetCards(Image card1, Image card2)
        {
            this.Image1 = card1;
            this.Image2 = card2;

            // wait a second, show the card first before showing its back again
            hasDelay = true;
            await Task.Delay(1000);

            // show the back of the card again.
            card1.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));
            card2.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));
            hasDelay = false;
        }

        /// <summary>
        /// Announce the winner of the game
        /// </summary>
        private void checkWinner()
        {
            // when the scores of player1 and player2 are the same
            if (scoreName1Tot == scoreName2Tot)
            {
                MessageBox.Show("Gelijkspel!");
            }
            // if the scores of player1 and player2 are not the same, announce the winner, who is the player with the most points
            else
            {
                string winner = (scoreName1Tot > scoreName2Tot) ? player1 : player2;
                MessageBox.Show(winner + " heeft gewonnen!");
            }
        }
    }
}
