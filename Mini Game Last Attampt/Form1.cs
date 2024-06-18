using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Game_Last_Attampt
{
    public partial class Form1 : Form
    {
        bool con_btn = Game_Window.con_btn_state;
        int heighScore = Game_Window.HeighSocre;
        //bool TimerState = Game_Window.gameTimerState;

        public Form1()
        {
            InitializeComponent();
          
            
        }

        //----------btn_start_MOUSE HOVER and MOUSE LEVE effect

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover_n;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\vishm\OneDrive\Desktop\HND\1 year 1st sem\VS Project\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_normal_n;
        }

        //--------------------btn_option MOUSE HOVER and MOUSE LEVE effect----------------- 

        private void btn_option_MouseHover(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_hover_n;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_option_MouseLeave(object sender, EventArgs e)
        {
            btn_option.Image = Properties.Resources.option_normal_n;
        }

        //--------------------btn_option MOUSE HOVER and MOUSE LEVE effect----------------- 

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover_n;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal_n;
        }
        //----------------btnStart Click Event Code--------------------------
        private void btn_start_Click(object sender, EventArgs e)
        {
            Game_Window game = new Game_Window();
            game.ShowDialog();
            btn_continue.Visible = true;

            
            
            
            this.Close();
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            option_menu option = new option_menu();
            option.ShowDialog();

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btn_continue_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }

        private void btn_continue_MouseHover(object sender, EventArgs e)
        {
            btn_continue.Image = Properties.Resources.con_hover_n;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            sound.Play();
        }

        private void btn_continue_MouseLeave(object sender, EventArgs e)
        {
            btn_continue.Image = Properties.Resources.con_normal_n;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            sound.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btn_continue.Visible = false;
            // this.Hide();
            if (con_btn == true)
            {
                btn_continue.Visible = true;
            }
            else
            {
                btn_continue.Visible = false;

            }

            lblTST.Text = heighScore.ToString();
           
        }
    }
}
