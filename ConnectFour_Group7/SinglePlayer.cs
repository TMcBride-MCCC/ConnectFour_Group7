using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group7
{
    public partial class SinglePlayer : Form
    {
        //Declare a Welcome form variable to point to
        private Welcome welcomeForm;
        //Make a Board varialbe to point to
        private Board board;
        //Variable for players
        private string player = "";
        //Variable counter for whose turn it is
        //Initial turn variable
        private int turnCounter = 1;


        public SinglePlayer(Welcome w)
        {
            InitializeComponent();

            //Initialize the board
            board = new Board();

            //loads board image
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "BoardBG.jpg");
            panel_singlePlayer_boardPanel.BackgroundImage = Image.FromFile(imagePath);
            panel_singlePlayer_boardPanel.BackgroundImageLayout = ImageLayout.Stretch;

            //Variable to house the form passed for reference later
            //Needed to return to the Main Menu
            welcomeForm = w;

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
                tssl_singlePlayer_p2.Visible = false;
                tssl_singlePlayer_p1.Visible = true;
                return "p1";
            }
            else
            {
                Console.WriteLine("Player 2's turn");
                tssl_singlePlayer_p1.Visible = false;
                tssl_singlePlayer_p2.Visible = true;
                return "p2";
            }
        }

        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_singlePlayer_exit_Click(object sender, EventArgs e)
        {
            //Closes the entire program
            System.Environment.Exit(0);
        }

        private void btn_singlePlayer_returnToMain_Click(object sender, EventArgs e)
        {
            //Hide the form
            this.Close();
            //Show the Main Menu form
            welcomeForm.Show();
        }

        private void panel_singlePlayer_boardPanel_Paint(object sender, PaintEventArgs e)
        {
            board.Draw(e.Graphics, panel_singlePlayer_boardPanel.Width, panel_singlePlayer_boardPanel.Height);
        }

        private void slotButtonClicked(object sender, EventArgs e)
        {
            int col = -1;
            int row;

            if (sender == btn_singlePlayer_slot1)
            {
                col = 0;
            }
            else if (sender == btn_singlePlayer_slot2)
            {
                col = 1;
            }
            else if(sender == btn_singlePlayer_slot3)
            {
                col = 2;
            }
            else if (sender == btn_singlePlayer_slot4)
            {
                col = 3;
            }
            else if (sender == btn_singlePlayer_slot5)
            {
                col = 4;
            }
            else if (sender == btn_singlePlayer_slot6)
            {
                col = 5;
            }
            else if (sender == btn_singlePlayer_slot7)
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
                //Increment the turn
                turnCounter++;
                //Refresh the board
                panel_singlePlayer_boardPanel.Invalidate();
                whoseTurnIsIt(turnCounter);
            }
        }
        private void hover(object sender, EventArgs e)
        {
            if (sender == btn_singlePlayer_slot1) //shows predetermined move
            {
                board.buttonHover(0);
                panel_singlePlayer_boardPanel.Invalidate();
            }
            else if (sender == btn_singlePlayer_slot2)
            {
                board.buttonHover(1);
                panel_singlePlayer_boardPanel.Invalidate();
            }
            else if (sender == btn_singlePlayer_slot3)
            {
                board.buttonHover(2);
                panel_singlePlayer_boardPanel.Invalidate();
            }
            else if (sender == btn_singlePlayer_slot4)
            {
                board.buttonHover(3);
                panel_singlePlayer_boardPanel.Invalidate();
            }
            else if (sender == btn_singlePlayer_slot5)
            {
                board.buttonHover(4);
                panel_singlePlayer_boardPanel.Invalidate();
            }
            else if (sender == btn_singlePlayer_slot6)
            {
                board.buttonHover(5);
                panel_singlePlayer_boardPanel.Invalidate();
            }
            else if (sender == btn_singlePlayer_slot7)
            {
                board.buttonHover(6);
                panel_singlePlayer_boardPanel.Invalidate();
            }
        }
        private void leaveHover(object sender, EventArgs e) //redraws board after mouse hover
        {
            board.buttonLeave(sender, e);
            panel_singlePlayer_boardPanel.Invalidate();
        }
    }
}
