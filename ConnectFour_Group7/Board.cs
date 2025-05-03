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
            int cellWidth = panelWidth/columns;
            int cellHeight = boardDrawHeight/rows;

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
                    fillTest();

                    //Draw filled piece
                    if (!cell.isEmptyCell())
                    {
                        Brush fillColor = new SolidBrush(cell.CellColor());
                        g.FillEllipse(fillColor, circleContainer);
                    }
                }
            }
        }

        public void fillTest()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    board[r, c].setPlayerThatFilled("p1");
                    board[r, c].setIsEmpty(false);
                }
            }
        }
    }
}
