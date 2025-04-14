namespace ConnectFour_Group7
{
    partial class Stats
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
            this.lbl_stats_title = new System.Windows.Forms.Label();
            this.btn_stats_exit = new System.Windows.Forms.Button();
            this.btn_stats_returnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stats_title
            // 
            this.lbl_stats_title.AutoSize = true;
            this.lbl_stats_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_title.Location = new System.Drawing.Point(333, 9);
            this.lbl_stats_title.Name = "lbl_stats_title";
            this.lbl_stats_title.Size = new System.Drawing.Size(114, 50);
            this.lbl_stats_title.TabIndex = 4;
            this.lbl_stats_title.Text = "Stats";
            // 
            // btn_stats_exit
            // 
            this.btn_stats_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats_exit.Location = new System.Drawing.Point(614, 397);
            this.btn_stats_exit.Name = "btn_stats_exit";
            this.btn_stats_exit.Size = new System.Drawing.Size(174, 41);
            this.btn_stats_exit.TabIndex = 5;
            this.btn_stats_exit.Text = "Exit";
            this.btn_stats_exit.UseVisualStyleBackColor = true;
            this.btn_stats_exit.Click += new System.EventHandler(this.btn_stats_exit_Click);
            // 
            // btn_stats_returnToMain
            // 
            this.btn_stats_returnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats_returnToMain.Location = new System.Drawing.Point(614, 350);
            this.btn_stats_returnToMain.Name = "btn_stats_returnToMain";
            this.btn_stats_returnToMain.Size = new System.Drawing.Size(174, 41);
            this.btn_stats_returnToMain.TabIndex = 8;
            this.btn_stats_returnToMain.Text = "Main Menu";
            this.btn_stats_returnToMain.UseVisualStyleBackColor = true;
            this.btn_stats_returnToMain.Click += new System.EventHandler(this.btn_stats_returnToMain_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stats_returnToMain);
            this.Controls.Add(this.btn_stats_exit);
            this.Controls.Add(this.lbl_stats_title);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stats_title;
        private System.Windows.Forms.Button btn_stats_exit;
        private System.Windows.Forms.Button btn_stats_returnToMain;
    }
}