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
    public partial class ReviewLastGame : Form
    {
        //Create a place in memory to store the previous game board
        private Board boardSave;
        //Create a place in memory to store the GameOver form that we just came from
        private GameOver gameOverForm;

        public ReviewLastGame(Board board, GameOver gameOverFormThatWasPassed)
        {
            InitializeComponent();
            boardSave = board;
            gameOverForm = gameOverFormThatWasPassed;
            //Loads board skin
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "BoardBG.jpg");
            panel_reviewGameBoard_boardPanel.BackgroundImage = Image.FromFile(imagePath);
            panel_reviewGameBoard_boardPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        //=====================================================================
        //                              ACTIONS
        //=====================================================================
        private void btn_reviewGameBoard_backToGameOver_Click(object sender, EventArgs e)
        {
            gameOverForm.Show();
            this.Close();
        }

        private void panel_reviewGameBoard_boardPanel_Paint(object sender, PaintEventArgs e)
        {
            boardSave.Draw(e.Graphics, panel_reviewGameBoard_boardPanel.Width, panel_reviewGameBoard_boardPanel.Height);
        }
    }
}
