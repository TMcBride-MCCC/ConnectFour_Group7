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
            this.lbl_gameOver_title = new System.Windows.Forms.Label();
            this.btn_gameOver_exit = new System.Windows.Forms.Button();
            this.btn_gameOver_returnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gameOver_title
            // 
            this.lbl_gameOver_title.AutoSize = true;
            this.lbl_gameOver_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver_title.Location = new System.Drawing.Point(277, 9);
            this.lbl_gameOver_title.Name = "lbl_gameOver_title";
            this.lbl_gameOver_title.Size = new System.Drawing.Size(209, 50);
            this.lbl_gameOver_title.TabIndex = 4;
            this.lbl_gameOver_title.Text = "Game Over";
            // 
            // btn_gameOver_exit
            // 
            this.btn_gameOver_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOver_exit.Location = new System.Drawing.Point(614, 397);
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
            this.btn_gameOver_returnToMain.Location = new System.Drawing.Point(614, 350);
            this.btn_gameOver_returnToMain.Name = "btn_gameOver_returnToMain";
            this.btn_gameOver_returnToMain.Size = new System.Drawing.Size(174, 41);
            this.btn_gameOver_returnToMain.TabIndex = 8;
            this.btn_gameOver_returnToMain.Text = "Main Menu";
            this.btn_gameOver_returnToMain.UseVisualStyleBackColor = true;
            this.btn_gameOver_returnToMain.Click += new System.EventHandler(this.btn_gameOver_returnToMain_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gameOver_returnToMain);
            this.Controls.Add(this.btn_gameOver_exit);
            this.Controls.Add(this.lbl_gameOver_title);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gameOver_title;
        private System.Windows.Forms.Button btn_gameOver_exit;
        private System.Windows.Forms.Button btn_gameOver_returnToMain;
    }
}