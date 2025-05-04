using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group7
{
    public partial class GameOver : Form
    {
        //Creat a spot in memory for the gameboard to be stored
        private Board lastBoard;
        private string winner;
        private Welcome welcomeForm;

        public GameOver(Board previousGameBoard, string playerWhoWon, Welcome wf)
        {
            InitializeComponent();

            lastBoard = previousGameBoard;
            winner = playerWhoWon;
            welcomeForm = wf;

            if (playerWhoWon == "p1")
            {
                lbl_gameOver_winner.Text = "Winner: Player 1";
            }
            else if (playerWhoWon == "p2")
            {
                lbl_gameOver_winner.Text = "Winner: Player 2";
            }
            else if (playerWhoWon == "ai")
            {
                lbl_gameOver_winner.Text = "Winnder: AI";
            }
            else
            {
                lbl_gameOver_winner.Text = "The game was a draw";
            }
        }
        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_gameOver_exit_Click(object sender, EventArgs e)
        {
            //Closes the entire program
            System.Environment.Exit(0);
        }

        private void btn_gameOver_returnToMain_Click(object sender, EventArgs e)
        {
            //Hide the form
            this.Close();
            //Show the Main Menu form
            welcomeForm.Show();
        }

        private void btn_gameOver_review_Click(object sender, EventArgs e)
        {
            //Create the review form
            //Pass it the last game board so that we can display it when needed
            //Pass it this form so that we may return
            ReviewLastGame reviewForm = new ReviewLastGame(lastBoard, this);
            reviewForm.Show();
            this.Hide();
        }

        private void btn_gameOver_playAgain_Click(object sender, EventArgs e)
        {
            Versus versusForm = new Versus(welcomeForm);
            //Show the Versus form
            versusForm.Show();
            //Hide the main form
            this.Hide();
        }
    }
}
