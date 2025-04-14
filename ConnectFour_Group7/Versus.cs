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
    public partial class Versus : Form
    {
        //Declare a Welcome form variable to point to
        private Welcome welcomeForm;

        public Versus(Welcome w)
        {
            InitializeComponent();
            //Variable to house the form passed for reference later
            //Needed to return to the Main Menu
            welcomeForm = w;
        }
        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_versus_exit_Click(object sender, EventArgs e)
        {
            //Closes the entire program
            System.Environment.Exit(0);
        }

        private void btn_versus_returnToMain_Click(object sender, EventArgs e)
        {
            //Hide the form
            this.Close();
            //Show the Main Menu form
            welcomeForm.Show();
        }
    }
}
