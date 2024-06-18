namespace Mini_Game_Last_Attampt
{
    partial class option_menu
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
            this.optionMenu = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.btn_Sound_Off = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sound_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // optionMenu
            // 
            this.optionMenu.BackColor = System.Drawing.Color.Transparent;
            this.optionMenu.BackgroundImage = global::Mini_Game_Last_Attampt.Properties.Resources.option_menu_n;
            this.optionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionMenu.Controls.Add(this.btn_Exit);
            this.optionMenu.Controls.Add(this.btn_Sound_Off);
            this.optionMenu.Controls.Add(this.trackBarVolume);
            this.optionMenu.Location = new System.Drawing.Point(48, 24);
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(287, 360);
            this.optionMenu.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = global::Mini_Game_Last_Attampt.Properties.Resources.exit_normal_n;
            this.btn_Exit.Location = new System.Drawing.Point(99, 291);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 43);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // btn_Sound_Off
            // 
            this.btn_Sound_Off.Image = global::Mini_Game_Last_Attampt.Properties.Resources.sound_on;
            this.btn_Sound_Off.Location = new System.Drawing.Point(120, 171);
            this.btn_Sound_Off.Name = "btn_Sound_Off";
            this.btn_Sound_Off.Size = new System.Drawing.Size(56, 56);
            this.btn_Sound_Off.TabIndex = 1;
            this.btn_Sound_Off.TabStop = false;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.Location = new System.Drawing.Point(99, 90);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(100, 45);
            this.trackBarVolume.TabIndex = 0;
            // 
            // option_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.optionMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "option_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option Menu";
            this.optionMenu.ResumeLayout(false);
            this.optionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sound_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionMenu;
        private System.Windows.Forms.PictureBox btn_Exit;
        private System.Windows.Forms.PictureBox btn_Sound_Off;
        private System.Windows.Forms.TrackBar trackBarVolume;
    }
}