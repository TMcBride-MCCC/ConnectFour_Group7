//========================================================
//Authors:  Tyler McBride, Dylan Dane
//Date:     4/10/2025
//Desc:     This program is a connect four game.
//========================================================


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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_welcome_singlePlayer_Click(object sender, EventArgs e)
        {
            //Make an instance of the SinglePlayer Form to point to
            //Pass it this form to come back to
            SinglePlayer singlePlayerForm = new SinglePlayer(this);
            //Show the Single Player form
            singlePlayerForm.Show();
            //Hide the main form
            this.Hide();
        }

        private void btn_welcome_versus_Click(object sender, EventArgs e)
        {
            //Make an instance of the Versus Form to point to
            //Pass it this form to come back to
            Versus versusForm = new Versus(this);
            //Show the Versus form
            versusForm.Show();
            //Hide the main form
            this.Hide();
        }

        private void btn_welcome_statistics_Click(object sender, EventArgs e)
        {
            //Make an instance of the Stats Form to point to
            //Pass it this form to come back to
            Stats statsForm = new Stats(this);
            //Show the Versus form
            statsForm.Show();
            //Hide the main form
            this.Hide();
        }

        private void btn_welcome_exit_Click(object sender, EventArgs e)
        {
            //This works because this is an exit from the main form
            Application.Exit();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
