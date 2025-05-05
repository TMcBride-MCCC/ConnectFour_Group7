using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ConnectFour_Group7
{
    public partial class Stats : Form
    {
        //Declare a Welcome form variable to point to
        private Welcome welcomeForm;
        private static int p1Wins = 0;
        private static int p2Wins = 0;
        private static int p1Lose = 0;
        private static int p2Lose = 0;
        private static int tie = 0;


        public Stats(Welcome w)
        {
            InitializeComponent();
            //Variable to house the form passed for reference later
            //Needed to return to the Main Menu
            welcomeForm = w;
            updateLabels();
        }
        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_stats_exit_Click(object sender, EventArgs e)
        {
            //Closes the entire program
            System.Environment.Exit(0);
        }

        private void btn_stats_returnToMain_Click(object sender, EventArgs e)
        {
            //Hide the form
            this.Close();
            //Show the Main Menu form
            welcomeForm.Show();
        }
        private void Stats_Load(object sender, EventArgs e)
        {

        }
        public void addWinP1() //player 1 wins player 2 loses
        {
            p1Wins++;
            p2Lose++;
            updateLabels();
        }
        public void addWinP2() //player 2 wins player 1 loses
        {
            p2Wins++;
            p1Lose++;
            updateLabels();
        }
        public void addTie() //game is tie
        {
            tie++;
            updateLabels();
        }
        public void updateLabels() //shows stats on form
        {
            label2.Text = "Wins: " + p1Wins;
            label3.Text = "Loses: " + p1Lose;
            label9.Text = "Wins: " + p2Wins;
            label8.Text = "Loses: " + p2Lose;
            label4.Text = "Ties: " + tie;
            label7.Text = "Ties: " + tie;

            //calculate win rates
            double p1WinRate = CalculateWinRate(p1Wins, p1Lose, tie);
            double p2WinRate = CalculateWinRate(p2Wins, p2Lose, tie);

            //update win % labels
            label5.Text = "Win %:" + " " + p1WinRate.ToString("0.00");
            label6.Text = "Win %: " + " " + p2WinRate.ToString("0.00");
        }
        private static double CalculateWinRate(int wins, int losses, int draws)
        {
            int totalGames = wins + losses + draws;

            
            if (totalGames == 0) //avoid breaking from dividing 0
            {
                return 0;  //no games played
            }

            return (double)wins / totalGames * 100;
        }
    }
}
