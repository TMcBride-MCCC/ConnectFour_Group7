using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group7
{
    internal class Cell
    {
        private int row;
        private int col;
        private bool isEmpty = true;
        private string playerThatFilled = null;

        public Cell(int r, int c)
        {
            row = r;
            col = c;
        }

        //================================================
        //                      SETTERS
        //================================================

        public void setRow(int r)
        {
            row = r;
        }

        public void setCol(int c)
        {
            col = c;
        }

        public void setIsEmpty(bool e)
        {
            isEmpty = e;
        }

        public void setPlayerThatFilled(string p)
        {
            playerThatFilled = p;
        }

        //================================================
        //                      GETTERS
        //================================================

        public int getRow()
        {
            return row;
        }

        public int getCol()
        {
            return col;
        }

        public bool isEmptyCell()
        {
            return isEmpty;
        }

        public string getPlayerThatFilled()
        {
            return playerThatFilled;
        }

        //================================================
        //                      Functions
        //================================================

        public Color CellColor()
        {
            if (playerThatFilled == "p1")
            {
                return Color.Red;
            }
            else if (playerThatFilled == "p2" || playerThatFilled == "ai")
            {
                return Color.Yellow;
            }
            else
            {
                return SystemColors.ActiveCaption;
            }

        }
    }
}
