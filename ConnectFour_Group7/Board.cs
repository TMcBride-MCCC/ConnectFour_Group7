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
        private const int padding = 2;
        private const int marginTop = 25;
        private const int marginBottom = 25;
        private int highlightRow = -1;
        private int highlightCol = -1;
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
        public void Draw(Graphics g, int panelWidth, int panelHeight)
        {
            int boardDrawHeight = panelHeight - marginTop - marginBottom;
            int cellWidth = panelWidth / columns;
            int cellHeight = boardDrawHeight / rows;

            int offsetX = (panelWidth - (cellWidth * columns)) / 2;
            int offsetY = marginTop;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Cell cell = board[r, c];

                    int x = c * cellWidth + offsetX;
                    int y = r * cellHeight + offsetY;

                    //Make the shape a circle
                    int circleSize = Math.Min(cellWidth, cellHeight) - padding * 2;
                    int centerXVal = x + (cellWidth - circleSize) / 2;
                    int centerYVal = y + (cellHeight - circleSize) / 2;

                    //Define the maximum space for the circle
                    Rectangle circleContainer = new Rectangle(centerXVal, centerYVal, circleSize, circleSize);

                    //TESTING
                    g.DrawEllipse(Pens.Black, circleContainer);
                    // fillTest();

                    //Draw filled piece
                    if (!cell.isEmptyCell())
                    {
                        Console.WriteLine("Filling NonEmpty Cell");
                        Brush fillColor = new SolidBrush(cell.CellColor());
                        g.FillEllipse(fillColor, circleContainer);
                    }
                    else
                    {
                        Console.WriteLine("Filling Empty Cell");
                        Brush fillColor = new SolidBrush(cell.CellColor());
                        g.FillEllipse(fillColor, circleContainer);
                    }
                    if (highlightRow == r && highlightCol == c) //makes transparent circle to show move before user registers
                    {
                        using (Brush highlight = new SolidBrush(Color.FromArgb(128, Color.Red)))
                        {
                            g.FillEllipse(highlight, circleContainer);
                        }
                    }
                }
            }
        }
        public void buttonHover(int column)
        {
            highlightRow = -1; //no intial highlight
            highlightCol = -1;

            for (int row = 5; row >= 0; row--) //loops bottom row up to top in set column
            {
                if (board[row, column].isEmptyCell()) //finds first empty cell from the bottom
                {
                    highlightRow = row;
                    highlightCol = column;
                    break;
                }
            }
        }
        public void buttonLeave(object sender, EventArgs e)
        {
            highlightRow = -1;
            highlightCol = -1;
        }

        public void fillTest()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    board[r, c].setPlayerThatFilled("");
                    board[r, c].setIsEmpty(false);
                }
            }
        }

        //Function for checking if a piece can be added
        public bool isColumnFull(int col)
        {
            for (int r = rows - 1; r >= 0; r--)
            {
                if (board[r, col].isEmptyCell())
                {
                    return false;
                }
            }
            //If the column is full
            return true;
        }

        public int getRow(int col)
        {
            for (int r = rows - 1; r >= 0; r--)
            {
                if (board[r, col].isEmptyCell())
                {
                    return r;
                }
            }
            return -1;
        }

        public void dropPiece(int col, int row, string player)
        {
            board[row, col].setPlayerThatFilled(player);
            board[row, col].setIsEmpty(false);
        }

        public Cell getCell(int row, int col)
        {
            return board[row, col];
        }
    }
}
