namespace ConnectFour_Group7
{
    partial class ReviewLastGame
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
            this.panel_reviewLastGame_top = new System.Windows.Forms.Panel();
            this.lbl_reviewLastGame_title = new System.Windows.Forms.Label();
            this.ss_reviewGameBoard_status = new System.Windows.Forms.StatusStrip();
            this.tssl_versus_p1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_versus_p2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_reviewGameBoard_boardPanel = new System.Windows.Forms.Panel();
            this.btn_reviewGameBoard_backToGameOver = new System.Windows.Forms.Button();
            this.panel_reviewLastGame_top.SuspendLayout();
            this.ss_reviewGameBoard_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_reviewLastGame_top
            // 
            this.panel_reviewLastGame_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_reviewLastGame_top.Controls.Add(this.lbl_reviewLastGame_title);
            this.panel_reviewLastGame_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_reviewLastGame_top.Location = new System.Drawing.Point(0, 0);
            this.panel_reviewLastGame_top.Name = "panel_reviewLastGame_top";
            this.panel_reviewLastGame_top.Size = new System.Drawing.Size(800, 52);
            this.panel_reviewLastGame_top.TabIndex = 9;
            // 
            // lbl_reviewLastGame_title
            // 
            this.lbl_reviewLastGame_title.AutoSize = true;
            this.lbl_reviewLastGame_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reviewLastGame_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_reviewLastGame_title.Name = "lbl_reviewLastGame_title";
            this.lbl_reviewLastGame_title.Size = new System.Drawing.Size(352, 50);
            this.lbl_reviewLastGame_title.TabIndex = 3;
            this.lbl_reviewLastGame_title.Text = "Game Board Review";
            // 
            // ss_reviewGameBoard_status
            // 
            this.ss_reviewGameBoard_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_versus_p1,
            this.tssl_versus_p2});
            this.ss_reviewGameBoard_status.Location = new System.Drawing.Point(0, 578);
            this.ss_reviewGameBoard_status.Name = "ss_reviewGameBoard_status";
            this.ss_reviewGameBoard_status.Size = new System.Drawing.Size(800, 22);
            this.ss_reviewGameBoard_status.TabIndex = 37;
            this.ss_reviewGameBoard_status.Text = "statusStrip1";
            // 
            // tssl_versus_p1
            // 
            this.tssl_versus_p1.BackColor = System.Drawing.Color.Red;
            this.tssl_versus_p1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssl_versus_p1.ForeColor = System.Drawing.Color.Black;
            this.tssl_versus_p1.Name = "tssl_versus_p1";
            this.tssl_versus_p1.Size = new System.Drawing.Size(87, 17);
            this.tssl_versus_p1.Text = "Player 1\'s Turn";
            this.tssl_versus_p1.Visible = false;
            // 
            // tssl_versus_p2
            // 
            this.tssl_versus_p2.BackColor = System.Drawing.Color.Yellow;
            this.tssl_versus_p2.ForeColor = System.Drawing.Color.Black;
            this.tssl_versus_p2.Name = "tssl_versus_p2";
            this.tssl_versus_p2.Size = new System.Drawing.Size(84, 17);
            this.tssl_versus_p2.Text = "Player 2\'s Turn";
            this.tssl_versus_p2.Visible = false;
            // 
            // panel_reviewGameBoard_boardPanel
            // 
            this.panel_reviewGameBoard_boardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(233)))));
            this.panel_reviewGameBoard_boardPanel.Location = new System.Drawing.Point(74, 93);
            this.panel_reviewGameBoard_boardPanel.Name = "panel_reviewGameBoard_boardPanel";
            this.panel_reviewGameBoard_boardPanel.Size = new System.Drawing.Size(650, 350);
            this.panel_reviewGameBoard_boardPanel.TabIndex = 29;
            this.panel_reviewGameBoard_boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_reviewGameBoard_boardPanel_Paint);
            // 
            // btn_reviewGameBoard_backToGameOver
            // 
            this.btn_reviewGameBoard_backToGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviewGameBoard_backToGameOver.Location = new System.Drawing.Point(614, 532);
            this.btn_reviewGameBoard_backToGameOver.Name = "btn_reviewGameBoard_backToGameOver";
            this.btn_reviewGameBoard_backToGameOver.Size = new System.Drawing.Size(174, 41);
            this.btn_reviewGameBoard_backToGameOver.TabIndex = 27;
            this.btn_reviewGameBoard_backToGameOver.Text = "Back";
            this.btn_reviewGameBoard_backToGameOver.UseVisualStyleBackColor = true;
            this.btn_reviewGameBoard_backToGameOver.Click += new System.EventHandler(this.btn_reviewGameBoard_backToGameOver_Click);
            // 
            // ReviewLastGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ss_reviewGameBoard_status);
            this.Controls.Add(this.panel_reviewGameBoard_boardPanel);
            this.Controls.Add(this.btn_reviewGameBoard_backToGameOver);
            this.Controls.Add(this.panel_reviewLastGame_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviewLastGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewLastGame";
            this.panel_reviewLastGame_top.ResumeLayout(false);
            this.panel_reviewLastGame_top.PerformLayout();
            this.ss_reviewGameBoard_status.ResumeLayout(false);
            this.ss_reviewGameBoard_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_reviewLastGame_top;
        private System.Windows.Forms.Label lbl_reviewLastGame_title;
        private System.Windows.Forms.StatusStrip ss_reviewGameBoard_status;
        private System.Windows.Forms.ToolStripStatusLabel tssl_versus_p1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_versus_p2;
        private System.Windows.Forms.Panel panel_reviewGameBoard_boardPanel;
        private System.Windows.Forms.Button btn_reviewGameBoard_backToGameOver;
    }
}