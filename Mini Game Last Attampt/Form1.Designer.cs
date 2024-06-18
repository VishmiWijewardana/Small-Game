namespace Mini_Game_Last_Attampt
{
    partial class Form1
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
            this.gameMenu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_option = new System.Windows.Forms.PictureBox();
            this.btn_continue = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.lblTST = new System.Windows.Forms.Label();
            this.gameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.SuspendLayout();
            // 
            // gameMenu
            // 
            this.gameMenu.BackgroundImage = global::Mini_Game_Last_Attampt.Properties.Resources.menu_n;
            this.gameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameMenu.Controls.Add(this.btn_exit);
            this.gameMenu.Controls.Add(this.btn_option);
            this.gameMenu.Controls.Add(this.btn_continue);
            this.gameMenu.Controls.Add(this.btn_start);
            this.gameMenu.Location = new System.Drawing.Point(48, 24);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(287, 360);
            this.gameMenu.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Mini_Game_Last_Attampt.Properties.Resources.exit_normal_n;
            this.btn_exit.Location = new System.Drawing.Point(97, 279);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 43);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_option
            // 
            this.btn_option.Image = global::Mini_Game_Last_Attampt.Properties.Resources.option_normal_n;
            this.btn_option.Location = new System.Drawing.Point(97, 213);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(100, 43);
            this.btn_option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_option.TabIndex = 0;
            this.btn_option.TabStop = false;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            this.btn_option.MouseLeave += new System.EventHandler(this.btn_option_MouseLeave);
            this.btn_option.MouseHover += new System.EventHandler(this.btn_option_MouseHover);
            // 
            // btn_continue
            // 
            this.btn_continue.Image = global::Mini_Game_Last_Attampt.Properties.Resources.con_normal_n;
            this.btn_continue.Location = new System.Drawing.Point(97, 81);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(100, 43);
            this.btn_continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_continue.TabIndex = 0;
            this.btn_continue.TabStop = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            this.btn_continue.MouseLeave += new System.EventHandler(this.btn_continue_MouseLeave);
            this.btn_continue.MouseHover += new System.EventHandler(this.btn_continue_MouseHover);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::Mini_Game_Last_Attampt.Properties.Resources.start_normal_n;
            this.btn_start.Location = new System.Drawing.Point(97, 147);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 43);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // lblTST
            // 
            this.lblTST.AutoSize = true;
            this.lblTST.Location = new System.Drawing.Point(341, 159);
            this.lblTST.Name = "lblTST";
            this.lblTST.Size = new System.Drawing.Size(35, 13);
            this.lblTST.TabIndex = 1;
            this.lblTST.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.lblTST);
            this.Controls.Add(this.gameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameMenu;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_option;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_continue;
        private System.Windows.Forms.Label lblTST;
    }
}

