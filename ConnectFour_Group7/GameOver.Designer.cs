namespace ConnectFour_Group7
{
    partial class GameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gameOver_exit = new System.Windows.Forms.Button();
            this.btn_gameOver_returnToMain = new System.Windows.Forms.Button();
            this.panel_welcome_top = new System.Windows.Forms.Panel();
            this.lbl_welcome_title = new System.Windows.Forms.Label();
            this.lbl_gameOver_winner = new System.Windows.Forms.Label();
            this.btn_gameOver_playAgain = new System.Windows.Forms.Button();
            this.btn_gameOver_review = new System.Windows.Forms.Button();
            this.panel_welcome_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_gameOver_exit
            // 
            this.btn_gameOver_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOver_exit.Location = new System.Drawing.Point(138, 595);
            this.btn_gameOver_exit.Name = "btn_gameOver_exit";
            this.btn_gameOver_exit.Size = new System.Drawing.Size(174, 41);
            this.btn_gameOver_exit.TabIndex = 5;
            this.btn_gameOver_exit.Text = "Exit";
            this.btn_gameOver_exit.UseVisualStyleBackColor = true;
            this.btn_gameOver_exit.Click += new System.EventHandler(this.btn_gameOver_exit_Click);
            // 
            // btn_gameOver_returnToMain
            // 
            this.btn_gameOver_returnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOver_returnToMain.Location = new System.Drawing.Point(138, 548);
            this.btn_gameOver_returnToMain.Name = "btn_gameOver_returnToMain";
            this.btn_gameOver_returnToMain.Size = new System.Drawing.Size(174, 41);
            this.btn_gameOver_returnToMain.TabIndex = 8;
            this.btn_gameOver_returnToMain.Text = "Main Menu";
            this.btn_gameOver_returnToMain.UseVisualStyleBackColor = true;
            this.btn_gameOver_returnToMain.Click += new System.EventHandler(this.btn_gameOver_returnToMain_Click);
            // 
            // panel_welcome_top
            // 
            this.panel_welcome_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_welcome_top.Controls.Add(this.lbl_welcome_title);
            this.panel_welcome_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_welcome_top.Location = new System.Drawing.Point(0, 0);
            this.panel_welcome_top.Name = "panel_welcome_top";
            this.panel_welcome_top.Size = new System.Drawing.Size(473, 52);
            this.panel_welcome_top.TabIndex = 9;
            // 
            // lbl_welcome_title
            // 
            this.lbl_welcome_title.AutoSize = true;
            this.lbl_welcome_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_welcome_title.Name = "lbl_welcome_title";
            this.lbl_welcome_title.Size = new System.Drawing.Size(209, 50);
            this.lbl_welcome_title.TabIndex = 2;
            this.lbl_welcome_title.Text = "Game Over";
            // 
            // lbl_gameOver_winner
            // 
            this.lbl_gameOver_winner.AutoSize = true;
            this.lbl_gameOver_winner.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver_winner.Location = new System.Drawing.Point(132, 78);
            this.lbl_gameOver_winner.Name = "lbl_gameOver_winner";
            this.lbl_gameOver_winner.Size = new System.Drawing.Size(202, 33);
            this.lbl_gameOver_winner.TabIndex = 11;
            this.lbl_gameOver_winner.Text = "Winner: Player 3";
            // 
            // btn_gameOver_playAgain
            // 
            this.btn_gameOver_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOver_playAgain.Location = new System.Drawing.Point(138, 501);
            this.btn_gameOver_playAgain.Name = "btn_gameOver_playAgain";
            this.btn_gameOver_playAgain.Size = new System.Drawing.Size(174, 41);
            this.btn_gameOver_playAgain.TabIndex = 12;
            this.btn_gameOver_playAgain.Text = "Play Again";
            this.btn_gameOver_playAgain.UseVisualStyleBackColor = true;
            this.btn_gameOver_playAgain.Click += new System.EventHandler(this.btn_gameOver_playAgain_Click);
            // 
            // btn_gameOver_review
            // 
            this.btn_gameOver_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOver_review.Location = new System.Drawing.Point(138, 432);
            this.btn_gameOver_review.Name = "btn_gameOver_review";
            this.btn_gameOver_review.Size = new System.Drawing.Size(174, 63);
            this.btn_gameOver_review.TabIndex = 13;
            this.btn_gameOver_review.Text = "Review The Board";
            this.btn_gameOver_review.UseVisualStyleBackColor = true;
            this.btn_gameOver_review.Click += new System.EventHandler(this.btn_gameOver_review_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 672);
            this.Controls.Add(this.btn_gameOver_review);
            this.Controls.Add(this.btn_gameOver_playAgain);
            this.Controls.Add(this.lbl_gameOver_winner);
            this.Controls.Add(this.panel_welcome_top);
            this.Controls.Add(this.btn_gameOver_returnToMain);
            this.Controls.Add(this.btn_gameOver_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.panel_welcome_top.ResumeLayout(false);
            this.panel_welcome_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gameOver_exit;
        private System.Windows.Forms.Button btn_gameOver_returnToMain;
        private System.Windows.Forms.Panel panel_welcome_top;
        private System.Windows.Forms.Label lbl_welcome_title;
        private System.Windows.Forms.Label lbl_gameOver_winner;
        private System.Windows.Forms.Button btn_gameOver_playAgain;
        private System.Windows.Forms.Button btn_gameOver_review;
    }
}