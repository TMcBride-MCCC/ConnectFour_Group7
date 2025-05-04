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
            this.panel_singlePlayer_top = new System.Windows.Forms.Panel();
            this.panel_singlePlayer_boardPanel = new System.Windows.Forms.Panel();
            this.btn_singlePlayer_slot1 = new System.Windows.Forms.Button();
            this.btn_singlePlayer_slot2 = new System.Windows.Forms.Button();
            this.btn_singlePlayer_slot3 = new System.Windows.Forms.Button();
            this.btn_singlePlayer_slot4 = new System.Windows.Forms.Button();
            this.btn_singlePlayer_slot5 = new System.Windows.Forms.Button();
            this.btn_singlePlayer_slot6 = new System.Windows.Forms.Button();
            this.btn_singlePlayer_slot7 = new System.Windows.Forms.Button();
            this.ss_singlePlayer_status = new System.Windows.Forms.StatusStrip();
            this.tssl_singlePlayer_p1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_singlePlayer_p2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_singlePlayer_top.SuspendLayout();
            this.ss_singlePlayer_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_singlePlayer_title
            // 
            this.lbl_singlePlayer_title.AutoSize = true;
            this.lbl_singlePlayer_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_singlePlayer_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_singlePlayer_title.Name = "lbl_singlePlayer_title";
            this.lbl_singlePlayer_title.Size = new System.Drawing.Size(242, 50);
            this.lbl_singlePlayer_title.TabIndex = 3;
            this.lbl_singlePlayer_title.Text = "Single Player";
            // 
            // btn_singlePlayer_exit
            // 
            this.btn_singlePlayer_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_singlePlayer_exit.Location = new System.Drawing.Point(614, 533);
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
            this.btn_singlePlayer_returnToMain.Location = new System.Drawing.Point(614, 486);
            this.btn_singlePlayer_returnToMain.Name = "btn_singlePlayer_returnToMain";
            this.btn_singlePlayer_returnToMain.Size = new System.Drawing.Size(174, 41);
            this.btn_singlePlayer_returnToMain.TabIndex = 6;
            this.btn_singlePlayer_returnToMain.Text = "Main Menu";
            this.btn_singlePlayer_returnToMain.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_returnToMain.Click += new System.EventHandler(this.btn_singlePlayer_returnToMain_Click);
            // 
            // panel_singlePlayer_top
            // 
            this.panel_singlePlayer_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_singlePlayer_top.Controls.Add(this.lbl_singlePlayer_title);
            this.panel_singlePlayer_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_singlePlayer_top.Location = new System.Drawing.Point(0, 0);
            this.panel_singlePlayer_top.Name = "panel_singlePlayer_top";
            this.panel_singlePlayer_top.Size = new System.Drawing.Size(800, 52);
            this.panel_singlePlayer_top.TabIndex = 7;
            // 
            // panel_singlePlayer_boardPanel
            // 
            this.panel_singlePlayer_boardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(233)))));
            this.panel_singlePlayer_boardPanel.Location = new System.Drawing.Point(74, 94);
            this.panel_singlePlayer_boardPanel.Name = "panel_singlePlayer_boardPanel";
            this.panel_singlePlayer_boardPanel.Size = new System.Drawing.Size(650, 350);
            this.panel_singlePlayer_boardPanel.TabIndex = 8;
            this.panel_singlePlayer_boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_singlePlayer_boardPanel_Paint);
            // 
            // btn_singlePlayer_slot1
            // 
            this.btn_singlePlayer_slot1.Location = new System.Drawing.Point(94, 58);
            this.btn_singlePlayer_slot1.Name = "btn_singlePlayer_slot1";
            this.btn_singlePlayer_slot1.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot1.TabIndex = 9;
            this.btn_singlePlayer_slot1.Text = "SLOT 1";
            this.btn_singlePlayer_slot1.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot1.Click += new System.EventHandler(this.slotButtonClicked);
            this.btn_singlePlayer_slot1.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot1.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_singlePlayer_slot2
            // 
            this.btn_singlePlayer_slot2.Location = new System.Drawing.Point(187, 58);
            this.btn_singlePlayer_slot2.Name = "btn_singlePlayer_slot2";
            this.btn_singlePlayer_slot2.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot2.TabIndex = 10;
            this.btn_singlePlayer_slot2.Text = "SLOT 2";
            this.btn_singlePlayer_slot2.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot2.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot2.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_singlePlayer_slot3
            // 
            this.btn_singlePlayer_slot3.Location = new System.Drawing.Point(277, 58);
            this.btn_singlePlayer_slot3.Name = "btn_singlePlayer_slot3";
            this.btn_singlePlayer_slot3.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot3.TabIndex = 11;
            this.btn_singlePlayer_slot3.Text = "SLOT 3";
            this.btn_singlePlayer_slot3.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot3.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot3.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_singlePlayer_slot4
            // 
            this.btn_singlePlayer_slot4.Location = new System.Drawing.Point(370, 58);
            this.btn_singlePlayer_slot4.Name = "btn_singlePlayer_slot4";
            this.btn_singlePlayer_slot4.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot4.TabIndex = 12;
            this.btn_singlePlayer_slot4.Text = "SLOT 4";
            this.btn_singlePlayer_slot4.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot4.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot4.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_singlePlayer_slot5
            // 
            this.btn_singlePlayer_slot5.Location = new System.Drawing.Point(462, 58);
            this.btn_singlePlayer_slot5.Name = "btn_singlePlayer_slot5";
            this.btn_singlePlayer_slot5.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot5.TabIndex = 13;
            this.btn_singlePlayer_slot5.Text = "SLOT 5";
            this.btn_singlePlayer_slot5.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot5.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot5.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_singlePlayer_slot6
            // 
            this.btn_singlePlayer_slot6.Location = new System.Drawing.Point(556, 58);
            this.btn_singlePlayer_slot6.Name = "btn_singlePlayer_slot6";
            this.btn_singlePlayer_slot6.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot6.TabIndex = 14;
            this.btn_singlePlayer_slot6.Text = "SLOT 6";
            this.btn_singlePlayer_slot6.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot6.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot6.MouseHover += new System.EventHandler(this.hover);
            // 
            // btn_singlePlayer_slot7
            // 
            this.btn_singlePlayer_slot7.Location = new System.Drawing.Point(647, 58);
            this.btn_singlePlayer_slot7.Name = "btn_singlePlayer_slot7";
            this.btn_singlePlayer_slot7.Size = new System.Drawing.Size(57, 30);
            this.btn_singlePlayer_slot7.TabIndex = 15;
            this.btn_singlePlayer_slot7.Text = "SLOT 7";
            this.btn_singlePlayer_slot7.UseVisualStyleBackColor = true;
            this.btn_singlePlayer_slot7.MouseLeave += new System.EventHandler(this.leaveHover);
            this.btn_singlePlayer_slot7.MouseHover += new System.EventHandler(this.hover);
            // 
            // ss_singlePlayer_status
            // 
            this.ss_singlePlayer_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_singlePlayer_p1,
            this.tssl_singlePlayer_p2});
            this.ss_singlePlayer_status.Location = new System.Drawing.Point(0, 578);
            this.ss_singlePlayer_status.Name = "ss_singlePlayer_status";
            this.ss_singlePlayer_status.Size = new System.Drawing.Size(800, 22);
            this.ss_singlePlayer_status.TabIndex = 16;
            this.ss_singlePlayer_status.Text = "statusStrip1";
            // 
            // tssl_singlePlayer_p1
            // 
            this.tssl_singlePlayer_p1.BackColor = System.Drawing.Color.Red;
            this.tssl_singlePlayer_p1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssl_singlePlayer_p1.ForeColor = System.Drawing.Color.Black;
            this.tssl_singlePlayer_p1.Name = "tssl_singlePlayer_p1";
            this.tssl_singlePlayer_p1.Size = new System.Drawing.Size(87, 17);
            this.tssl_singlePlayer_p1.Text = "Player 1\'s Turn";
            this.tssl_singlePlayer_p1.Visible = false;
            // 
            // tssl_singlePlayer_p2
            // 
            this.tssl_singlePlayer_p2.BackColor = System.Drawing.Color.Yellow;
            this.tssl_singlePlayer_p2.ForeColor = System.Drawing.Color.Black;
            this.tssl_singlePlayer_p2.Name = "tssl_singlePlayer_p2";
            this.tssl_singlePlayer_p2.Size = new System.Drawing.Size(83, 17);
            this.tssl_singlePlayer_p2.Text = "Player 2\'s Turn";
            this.tssl_singlePlayer_p2.Visible = false;
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ss_singlePlayer_status);
            this.Controls.Add(this.btn_singlePlayer_slot7);
            this.Controls.Add(this.btn_singlePlayer_slot6);
            this.Controls.Add(this.btn_singlePlayer_slot5);
            this.Controls.Add(this.btn_singlePlayer_slot4);
            this.Controls.Add(this.btn_singlePlayer_slot3);
            this.Controls.Add(this.btn_singlePlayer_slot2);
            this.Controls.Add(this.btn_singlePlayer_slot1);
            this.Controls.Add(this.panel_singlePlayer_boardPanel);
            this.Controls.Add(this.panel_singlePlayer_top);
            this.Controls.Add(this.btn_singlePlayer_returnToMain);
            this.Controls.Add(this.btn_singlePlayer_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinglePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_singlePlayer_top.ResumeLayout(false);
            this.panel_singlePlayer_top.PerformLayout();
            this.ss_singlePlayer_status.ResumeLayout(false);
            this.ss_singlePlayer_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_singlePlayer_title;
        private System.Windows.Forms.Button btn_singlePlayer_exit;
        private System.Windows.Forms.Button btn_singlePlayer_returnToMain;
        private System.Windows.Forms.Panel panel_singlePlayer_top;
        private System.Windows.Forms.Panel panel_singlePlayer_boardPanel;
        private System.Windows.Forms.Button btn_singlePlayer_slot1;
        private System.Windows.Forms.Button btn_singlePlayer_slot2;
        private System.Windows.Forms.Button btn_singlePlayer_slot3;
        private System.Windows.Forms.Button btn_singlePlayer_slot4;
        private System.Windows.Forms.Button btn_singlePlayer_slot5;
        private System.Windows.Forms.Button btn_singlePlayer_slot6;
        private System.Windows.Forms.Button btn_singlePlayer_slot7;
        private System.Windows.Forms.StatusStrip ss_singlePlayer_status;
        private System.Windows.Forms.ToolStripStatusLabel tssl_singlePlayer_p1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_singlePlayer_p2;
    }
}