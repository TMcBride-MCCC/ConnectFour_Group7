namespace ConnectFour_Group7
{
    partial class Versus
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
            this.lbl_versus_title = new System.Windows.Forms.Label();
            this.btn_versus_exit = new System.Windows.Forms.Button();
            this.btn_versus_returnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_versus_title
            // 
            this.lbl_versus_title.AutoSize = true;
            this.lbl_versus_title.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versus_title.Location = new System.Drawing.Point(360, 9);
            this.lbl_versus_title.Name = "lbl_versus_title";
            this.lbl_versus_title.Size = new System.Drawing.Size(78, 50);
            this.lbl_versus_title.TabIndex = 4;
            this.lbl_versus_title.Text = "Vs.";
            // 
            // btn_versus_exit
            // 
            this.btn_versus_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_versus_exit.Location = new System.Drawing.Point(614, 397);
            this.btn_versus_exit.Name = "btn_versus_exit";
            this.btn_versus_exit.Size = new System.Drawing.Size(174, 41);
            this.btn_versus_exit.TabIndex = 5;
            this.btn_versus_exit.Text = "Exit";
            this.btn_versus_exit.UseVisualStyleBackColor = true;
            this.btn_versus_exit.Click += new System.EventHandler(this.btn_versus_exit_Click);
            // 
            // btn_versus_returnToMain
            // 
            this.btn_versus_returnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_versus_returnToMain.Location = new System.Drawing.Point(614, 350);
            this.btn_versus_returnToMain.Name = "btn_versus_returnToMain";
            this.btn_versus_returnToMain.Size = new System.Drawing.Size(174, 41);
            this.btn_versus_returnToMain.TabIndex = 7;
            this.btn_versus_returnToMain.Text = "Main Menu";
            this.btn_versus_returnToMain.UseVisualStyleBackColor = true;
            this.btn_versus_returnToMain.Click += new System.EventHandler(this.btn_versus_returnToMain_Click);
            // 
            // Versus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_versus_returnToMain);
            this.Controls.Add(this.btn_versus_exit);
            this.Controls.Add(this.lbl_versus_title);
            this.Name = "Versus";
            this.Text = "Versus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_versus_title;
        private System.Windows.Forms.Button btn_versus_exit;
        private System.Windows.Forms.Button btn_versus_returnToMain;
    }
}