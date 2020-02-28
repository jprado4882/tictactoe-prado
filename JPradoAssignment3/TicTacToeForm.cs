/*
 * TicTacToeForm.cs
 * Description: a form that generates a tictactoe game.
 *    Used old tile array template from previous
 *    assignment to generate the tiles.
 * 
 * Revision History:
 *          Jemillee Prado 12-01-2019 : Created
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPradoAssignment3
{
    public partial class TicTacToeForm : Form
    {               

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        //Declare/Init Const
        const int WIDTH = 77;
        const int HEIGHT = 77;
        const int HGAP = 3;
        const int VGAP = 3;
        const int TOP = 3; //in panel
        const int LEFT = 3; //in panel
        const int ROWS = 3;
        const int COLUMNS = 3;

        //declare turns made
        public int turnsMade;

        //Array for the pictureboxes
        JPTile[,] tiles;

        /// <summary>
        /// Loads all necessary items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            //rows/cols/left/right
            int rows = ROWS;
            int cols = COLUMNS;
            int x = LEFT;
            int y = TOP;

            //initialize the tile
            tiles = new JPTile[rows, cols];          

            //Load in the picture box, empty.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //generate the tiles for X&O
                    tiles[i, j] = new JPTile
                    {
                        //Name = "tile" + i + j,
                        Left = x,
                        Top = y,
                        Width = WIDTH,
                        Height = HEIGHT,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle,
                        Code = "N",

                    };

                    Console.WriteLine($"Tile: 1 Row: {i} Column: {j}");

                    //spawn tile to the right of tile, add horizontal gap
                    x += WIDTH + HGAP;

                    //insert to panel, add control
                    this.pnlTile.Controls.Add(tiles[i, j]);

                    //add control to click event handler
                    tiles[i, j].Click += new EventHandler(tileChange_Click);
                }
                // spawn tile under the tile above, add vertical gap
                y += HEIGHT + VGAP;

                // resets x to start at col 0
                x = LEFT;
            }
        }

        /// <summary>
        /// changes the tile upon click
        /// to the specific X or O image
        /// based on the turns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileChange_Click(object sender, EventArgs e)
        {
            //picturebox sender
            JPTile tile = (JPTile)sender;

            //this allows no override of codes
            //check if tile is empty
            if (tile.Code == "N")
            {              
                //check if keypressed has to remainder
                if (turnsMade % 2 == 0)
                {
                    //change all to X type tile (code + img)
                    tile.Code = "X";
                    tile.Image = Properties.Resources.XKey;
                    Console.WriteLine("KEYPRESS X: " + turnsMade);
                }
                else
                {
                    //change all to O type tile
                    tile.Code = "O";
                    tile.Image = Properties.Resources.OKey;
                    Console.WriteLine("KEYPRESS O: " + turnsMade);
                }
                Console.WriteLine("KEYPRESS END: " + turnsMade);
                turnsMade++;
            }

            //WinCheck + access to turnsMade
            KeyArrayChecker keys = new KeyArrayChecker(this, tiles);
            keys.CheckWinner();

        }


    }
}
