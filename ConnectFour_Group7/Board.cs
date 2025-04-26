using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group7
{
    public class Board
    {
        private const int rows = 6;
        private const int columns = 7;
        private Cell[,] board;
        

        public Board()
        {
            board = new Cell[rows, columns];
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    board[r, c] = new Cell(r, c);
                }
            }
        }
    }
}
