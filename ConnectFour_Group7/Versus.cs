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

        public Versus(Welcome w)
        {
            InitializeComponent();

            //Initialize the board
            board = new Board();

            //loads board image
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "BoardBG.jpg");
            panel_versus_boardPanel.BackgroundImage = Image.FromFile(imagePath);
            panel_versus_boardPanel.BackgroundImageLayout = ImageLayout.Stretch;

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
        private void btn_singlePlayer_exit_Click_1(object sender, EventArgs e)
        {
            //Closes the entire program
            System.Environment.Exit(0);
        }

        private void btn_singlePlayer_returnToMain_Click_1(object sender, EventArgs e)
        {
            //Hide the form
            this.Close();
            //Show the Main Menu form
            welcomeForm.Show();
        }

        private void panel_singlePlayer_boardPanel_Paint_1(object sender, PaintEventArgs e)
        {
            board.Draw(e.Graphics, panel_versus_boardPanel.Width, panel_versus_boardPanel.Height);
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
        }
        private void leaveHover(object sender, EventArgs e) //redraws board after mouse hover
        {
            board.buttonLeave(sender, e);
            panel_versus_boardPanel.Invalidate();
        }

        private void btn_versus_slot1_Click(object sender, EventArgs e)
        {
        }
    }
}
