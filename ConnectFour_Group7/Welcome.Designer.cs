namespace ConnectFour_Group7
{
    partial class Welcome
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
            this.panel_welcome_top = new System.Windows.Forms.Panel();
            this.lbl_welcome_title = new System.Windows.Forms.Label();
            this.btn_welcome_singlePlayer = new System.Windows.Forms.Button();
            this.btn_welcome_versus = new System.Windows.Forms.Button();
            this.btn_welcome_statistics = new System.Windows.Forms.Button();
            this.btn_welcome_exit = new System.Windows.Forms.Button();
            this.panel_welcome_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_welcome_top
            // 
            this.panel_welcome_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_welcome_top.Controls.Add(this.lbl_welcome_title);
            this.panel_welcome_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_welcome_top.Location = new System.Drawing.Point(0, 0);
            this.panel_welcome_top.Name = "panel_welcome_top";
            this.panel_welcome_top.Size = new System.Drawing.Size(473, 52);
            this.panel_welcome_top.TabIndex = 0;
            // 
            // lbl_welcome_title
            // 
            this.lbl_welcome_title.AutoSize = true;
            this.lbl_welcome_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_welcome_title.Name = "lbl_welcome_title";
            this.lbl_welcome_title.Size = new System.Drawing.Size(241, 50);
            this.lbl_welcome_title.TabIndex = 2;
            this.lbl_welcome_title.Text = "Connect Four";
            // 
            // btn_welcome_singlePlayer
            // 
            this.btn_welcome_singlePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welcome_singlePlayer.Location = new System.Drawing.Point(138, 129);
            this.btn_welcome_singlePlayer.Name = "btn_welcome_singlePlayer";
            this.btn_welcome_singlePlayer.Size = new System.Drawing.Size(174, 41);
            this.btn_welcome_singlePlayer.TabIndex = 1;
            this.btn_welcome_singlePlayer.Text = "Single Player";
            this.btn_welcome_singlePlayer.UseVisualStyleBackColor = true;
            this.btn_welcome_singlePlayer.Click += new System.EventHandler(this.btn_welcome_singlePlayer_Click);
            // 
            // btn_welcome_versus
            // 
            this.btn_welcome_versus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welcome_versus.Location = new System.Drawing.Point(138, 190);
            this.btn_welcome_versus.Name = "btn_welcome_versus";
            this.btn_welcome_versus.Size = new System.Drawing.Size(174, 41);
            this.btn_welcome_versus.TabIndex = 2;
            this.btn_welcome_versus.Text = "Vs.";
            this.btn_welcome_versus.UseVisualStyleBackColor = true;
            this.btn_welcome_versus.Click += new System.EventHandler(this.btn_welcome_versus_Click);
            // 
            // btn_welcome_statistics
            // 
            this.btn_welcome_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welcome_statistics.Location = new System.Drawing.Point(138, 255);
            this.btn_welcome_statistics.Name = "btn_welcome_statistics";
            this.btn_welcome_statistics.Size = new System.Drawing.Size(174, 41);
            this.btn_welcome_statistics.TabIndex = 3;
            this.btn_welcome_statistics.Text = "Stats";
            this.btn_welcome_statistics.UseVisualStyleBackColor = true;
            this.btn_welcome_statistics.Click += new System.EventHandler(this.btn_welcome_statistics_Click);
            // 
            // btn_welcome_exit
            // 
            this.btn_welcome_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_welcome_exit.Location = new System.Drawing.Point(138, 595);
            this.btn_welcome_exit.Name = "btn_welcome_exit";
            this.btn_welcome_exit.Size = new System.Drawing.Size(174, 41);
            this.btn_welcome_exit.TabIndex = 4;
            this.btn_welcome_exit.Text = "Exit";
            this.btn_welcome_exit.UseVisualStyleBackColor = true;
            this.btn_welcome_exit.Click += new System.EventHandler(this.btn_welcome_exit_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 672);
            this.Controls.Add(this.btn_welcome_exit);
            this.Controls.Add(this.btn_welcome_statistics);
            this.Controls.Add(this.btn_welcome_versus);
            this.Controls.Add(this.btn_welcome_singlePlayer);
            this.Controls.Add(this.panel_welcome_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_welcome_top.ResumeLayout(false);
            this.panel_welcome_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_welcome_top;
        private System.Windows.Forms.Button btn_welcome_singlePlayer;
        private System.Windows.Forms.Label lbl_welcome_title;
        private System.Windows.Forms.Button btn_welcome_versus;
        private System.Windows.Forms.Button btn_welcome_statistics;
        private System.Windows.Forms.Button btn_welcome_exit;
    }
}

