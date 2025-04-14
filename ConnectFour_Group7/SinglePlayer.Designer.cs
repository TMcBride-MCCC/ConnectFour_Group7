namespace ConnectFour_Group7
{
    partial class SinglePlayer
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
            this.lbl_singlePlayer_title = new System.Windows.Forms.Label();
            this.btn_singlePlayer_exit = new System.Windows.Forms.Button();
            this.btn_singlePlayer_returnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_singlePlayer_title
            // 
            this.lbl_singlePlayer_title.AutoSize = true;
            this.lbl_singlePlayer_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_singlePlayer_title.Location = new System.Drawing.Point(272, 9);
            this.lbl_singlePlayer_title.Name = "lbl_singlePlayer_title";
            this.lbl_singlePlayer_title.Size = new System.Drawing.Size(242, 50);
            this.lbl_singlePlayer_title.TabIndex = 3;
            this.lbl_singlePlayer_title.Text = "Single Player";
            // 
            // btn_singlePlayer_exit
            // 
            this.btn_singlePlayer_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_singlePlayer_exit.Location = new System.Drawing.Point(614, 397);
            this.btn_singlePlayer_exit.Name = "btn_singlePlayer_exit";
            this.btn_singlePlayer_exit.Size = new System.Drawing.Size(174, 41);
            this.btn_singlePlayer_exit.TabIndex = 5;
            this.btn_singlePlayer_exit.Text = "Exit";
            this.btn_singlePlayer_exit.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_exit.Click += new System.EventHandler(this.btn_singlePlayer_exit_Click);
            // 
            // btn_singlePlayer_returnToMain
            // 
            this.btn_singlePlayer_returnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_singlePlayer_returnToMain.Location = new System.Drawing.Point(614, 350);
            this.btn_singlePlayer_returnToMain.Name = "btn_singlePlayer_returnToMain";
            this.btn_singlePlayer_returnToMain.Size = new System.Drawing.Size(174, 41);
            this.btn_singlePlayer_returnToMain.TabIndex = 6;
            this.btn_singlePlayer_returnToMain.Text = "Main Menu";
            this.btn_singlePlayer_returnToMain.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_returnToMain.Click += new System.EventHandler(this.btn_singlePlayer_returnToMain_Click);
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_singlePlayer_returnToMain);
            this.Controls.Add(this.btn_singlePlayer_exit);
            this.Controls.Add(this.lbl_singlePlayer_title);
            this.Name = "SinglePlayer";
            this.Text = "SinglePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_singlePlayer_title;
        private System.Windows.Forms.Button btn_singlePlayer_exit;
        private System.Windows.Forms.Button btn_singlePlayer_returnToMain;
    }
}