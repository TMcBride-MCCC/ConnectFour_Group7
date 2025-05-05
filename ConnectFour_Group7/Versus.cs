using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group7
{
    public partial class Versus : Form
    {
        //Declare a Welcome form variable to point to
        private Welcome welcomeForm;
        //Make a Board varialbe to point to
        private Board board;
        private Stats stats;
        private int turnCounter = 1;
        public Versus(Welcome wf)
        {
            InitializeComponent();

            //Initialize the board
            board = new Board();
            stats = new Stats(wf);

            //loads board image
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "BoardBG.jpg");
            panel_versus_boardPanel.BackgroundImage = Image.FromFile(imagePath);
            panel_versus_boardPanel.BackgroundImageLayout = ImageLayout.Stretch;

            //Variable to house the form passed for reference later
            //Needed to return to the Main Menu
            welcomeForm = wf;
            //Set the turn
            whoseTurnIsIt(turnCounter);
        }
        //=====================================================================
        //                              FUNCTIONS
        //=====================================================================
        private string whoseTurnIsIt(int tc)
        {
            if (tc % 2 != 0)
            {
                Console.WriteLine("Player 1's turn");
                tssl_versus_p2.Visible = false;
                tssl_versus_p1.Visible = true;
                return "p1";
            }
            else
            {
                Console.WriteLine("Player 2's turn");
                tssl_versus_p1.Visible = false;
                tssl_versus_p2.Visible = true;
                return "p2";
            }
        }
        private bool checkWin(int row, int col, string player)
        {
            //======================
            //===Horizontal check===
            //======================

            //Check to the west
            int westCount = 0;
            int westCol = col - 1;
            while (westCol >= 0 && board.getCell(row, westCol).getPlayerThatFilled() == player)
            {
                westCount++;
                westCol--;
            }

            //Check to the east
            int eastCount = 0;
            int eastCol = col + 1;
            while (eastCol <= 6 && board.getCell(row, eastCol).getPlayerThatFilled() == player)
            {
                eastCount++;
                eastCol++;
            }

            //Add the counts together and check for total count
            if((westCount + eastCount + 1) >= 4)
            {
                return true;
            }

            //======================
            //====Vertical check====
            //======================

            //Check to the north
            int northCount = 0;
            int northRow = row - 1;
            while (northRow >= 0 && board.getCell(northRow, col).getPlayerThatFilled() == player)
            {
                northCount++;
                northRow--;
            }

            //Check to the south
            int southCount = 0;
            int southRow = row + 1;
            while (southRow <= 5 && board.getCell(southRow, col).getPlayerThatFilled() == player)
            {
                southCount++;
                southRow++;
            }

            //Add the counts together and check for total count
            if ((northCount + southCount + 1) >= 4)
            {
                return true;
            }

            //=========================
            //====Diagonal check #1====
            //=========================

            //Check to the NW
            int nwCount = 0;
            int nwCol = col - 1;
            int nwRow = row - 1;
            while (nwRow >= 0 && nwCol >= 0 && board.getCell(nwRow, nwCol).getPlayerThatFilled() == player)
            {
                nwCount++;
                nwRow--;
                nwCol--;
            }

            //Check to the SW
            int swCount = 0;
            int swCol = col - 1;
            int swRow = row + 1;
            while (swRow <= 5 && swCol >= 0 && board.getCell(swRow, swCol).getPlayerThatFilled() == player)
            {
                swCount++;
                swRow++;
                swCol--;
            }

            //Add the counts together and check for total count
            if ((nwCount + swCount + 1) >= 4)
            {
                return true;
            }

            //=========================
            //====Diagonal check #2====
            //=========================

            //Check to the NE
            int neCount = 0;
            int neCol = col + 1;
            int neRow = row - 1;
            while (neRow >= 0 && neCol <= 6 && board.getCell(neRow, neCol).getPlayerThatFilled() == player)
            {
                neCount++;
                neRow--;
                neCol++;
            }

            //Check to the SE
            int seCount = 0;
            int seCol = col + 1;
            int seRow = row + 1;
            while (seRow <= 5 && seCol <= 6 && board.getCell(seRow, seCol).getPlayerThatFilled() == player)
            {
                seCount++;
                seRow++;
                seCol++;
            }

            //Add the counts together and check for total count
            if ((neCount + seCount + 1) >= 4)
            {
                return true;
            }

            return false;
        }

        private bool checkDraw()
        {
            if (turnCounter >= 42)
            {
                disableButtons();  //disables all button
                GameOver gameOverForm = new GameOver(board, "Draw", welcomeForm, stats);
                gameOverForm.Show(); //shows game over form
                this.Hide();  // Hide the current form
                return true; //tie game
            }

            return false; //not a tie...yet
        }

        private void disableButtons()
        {
            btn_versus_slot1.Enabled = false;
            btn_versus_slot2.Enabled = false;
            btn_versus_slot3.Enabled = false;
            btn_versus_slot4.Enabled = false;
            btn_versus_slot5.Enabled = false;
            btn_versus_slot6.Enabled = false;
            btn_versus_slot7.Enabled = false;
        }

        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_versus_exit_Click_1(object sender, EventArgs e)
        {
            //Closes the entire program
            System.Environment.Exit(0);
        }

        private void btn_versus_returnToMain_Click_1(object sender, EventArgs e)
        {
            //Hide the form
            this.Close();
            //Show the Main Menu form
            welcomeForm.Show();
        }

        private void panel_versus_boardPanel_Paint_1(object sender, PaintEventArgs e)
        {
            board.Draw(e.Graphics, panel_versus_boardPanel.Width, panel_versus_boardPanel.Height);
        }

        private void slotButtonClicked(object sender, EventArgs e)
        {
            int col = -1;
            int row;

            if (sender == btn_versus_slot1)
            {
                col = 0;
            }
            else if (sender == btn_versus_slot2)
            {
                col = 1;
            }
            else if (sender == btn_versus_slot3)
            {
                col = 2;
            }
            else if (sender == btn_versus_slot4)
            {
                col = 3;
            }
            else if (sender == btn_versus_slot5)
            {
                col = 4;
            }
            else if (sender == btn_versus_slot6)
            {
                col = 5;
            }
            else if (sender == btn_versus_slot7)
            {
                col = 6;
            }

            string player = whoseTurnIsIt(turnCounter);
            bool columnIsFull = board.isColumnFull(col);

            if (columnIsFull)
            {
                MessageBox.Show("Column is full. Play again");
            }
            else
            {
                row = board.getRow(col);
                //Make the move
                board.dropPiece(col, row, player);
                //Refresh the board
                panel_versus_boardPanel.Invalidate();
                //Check for a win
                if (checkWin(row, col, player))
                {
                    //Temporary display that this function is working
                    //After we determine it is working this will be replaced with a form
                    //MessageBox.Show(player + " Won!");
                    //Disable all buttons
                    disableButtons();
                    //Make an instance of the Versus Form to point to
                    //Pass it this form to come back to
                    GameOver gameOverForm = new GameOver(board, player, welcomeForm, stats);
                    //Show the Versus form
                    gameOverForm.Show();
                    //Hide the main form
                    this.Hide();
                }
                else if (checkDraw())
                {

                }
                else
                {
                    //Increment the turn
                    turnCounter++;
                    whoseTurnIsIt(turnCounter);
                }
            }
        }
        private void hover(object sender, EventArgs e)
        {
            if (sender == btn_versus_slot1) //shows predetermined move
            {
                board.buttonHover(0);
                panel_versus_boardPanel.Invalidate();
            }
            else if (sender == btn_versus_slot2)
            {
                board.buttonHover(1);
                panel_versus_boardPanel.Invalidate();
            }
            else if (sender == btn_versus_slot3)
            {
                board.buttonHover(2);
                panel_versus_boardPanel.Invalidate();
            }
            else if (sender == btn_versus_slot4)
            {
                board.buttonHover(3);
                panel_versus_boardPanel.Invalidate();
            }
            else if (sender == btn_versus_slot5)
            {
                board.buttonHover(4);
                panel_versus_boardPanel.Invalidate();
            }
            else if (sender == btn_versus_slot6)
            {
                board.buttonHover(5);
                panel_versus_boardPanel.Invalidate();
            }
            else if (sender == btn_versus_slot7)
            {
                board.buttonHover(6);
                panel_versus_boardPanel.Invalidate();
            }
        }
        private void leaveHover(object sender, EventArgs e) //redraws board after mouse hover
        {
            board.buttonLeave(sender, e);
            panel_versus_boardPanel.Invalidate();
        }
    }
}
