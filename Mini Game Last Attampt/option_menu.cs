using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Game_Last_Attampt
{
    public partial class option_menu : Form
    {
        public option_menu()
        {
            InitializeComponent();
        }

        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.Image = Properties.Resources.exit_hover_n;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.Image = Properties.Resources.exit_normal_n;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
