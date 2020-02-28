/*
 * KeyArrayChecker.cs
 * Description: a class to check for winnings,
 *      and to initiate new game,
 * 
 * Revision History:
 *          Jemillee Prado 12-01-2019 : Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPradoAssignment3
{
    public class KeyArrayChecker
    {
        private JPTile[,] array;
        private TicTacToeForm form;

        public KeyArrayChecker(TicTacToeForm form,
            JPTile[,] array)
        {
            this.form = form;
            this.array = array;
        }

        /// <summary>
        /// "Generates a new game"
        /// </summary>
        public void NewGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j].Code = "N";
                    array[i, j].Image = null;
                    form.turnsMade = 0; //access form keypress.
                }
            }
        }

        public void CheckWinner()
        {
            //for loop to check the codes.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Horizontal Check
                    if (array[i, 0].Code != "N" &&
                        (array[i, 1].Code == array[i, 0].Code &&
                        array[i, 2].Code == array[i, 0].Code))
                    {
                        MessageBox.Show($"{array[i, 0].Code.ToString()} wins", "Tic Tac Toe", MessageBoxButtons.OK);
                        NewGame();
                    }

                    //Vertical Check
                    if (array[0, j].Code != "N" &&
                        (array[1, j].Code == array[0, j].Code &&
                        array[2, j].Code == array[0, j].Code))
                    {
                        MessageBox.Show($"{array[0, j].Code.ToString()} wins", "Tic Tac Toe", MessageBoxButtons.OK);
                        NewGame();
                    }
                }
            }
                       
            //Diagonal Check upper left to lower right
            if (array[0, 0].Code != "N" &&
                (array[1, 1].Code == array[0, 0].Code &&
                array[2, 2].Code == array[0, 0].Code))
            {
                MessageBox.Show($"{array[0, 0].Code.ToString()} wins", "Tic Tac Toe", MessageBoxButtons.OK);
                NewGame();
            }

            //Diagonal Check upper right to lower left
            if (array[0, 2].Code != "N" &&
                (array[1, 1].Code == array[0, 2].Code &&
                array[2, 0].Code == array[0, 2].Code))
            {
                MessageBox.Show($"{array[0, 2].Code.ToString()} wins", "Tic Tac Toe", MessageBoxButtons.OK);
                NewGame();
            }

            int fullTile = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (array[i,j].Code == "O" || array[i,j].Code == "X")
                    {
                        fullTile++;
                    }

                    if(fullTile == 9)
                    {
                        MessageBox.Show($"It's a tie!", "Tic Tac Toe", MessageBoxButtons.OK);
                        NewGame();
                    }
                }
            }
        }
    }
}
