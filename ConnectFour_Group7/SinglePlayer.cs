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
        }
        //=====================================================================
        //                              FUNCTIONS
        //=====================================================================

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_singlePlayer_boardPanel_Paint(object sender, PaintEventArgs e)
        {
            board.Draw(e.Graphics, panel_singlePlayer_boardPanel.Width, panel_singlePlayer_boardPanel.Height);
        }
    }
}
