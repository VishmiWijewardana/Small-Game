using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Mini_Game_Last_Attampt
{


    public partial class Game_Window : Form
    {
        bool goleft; // this boolean will be used to check if the rabit move left
        bool goright; // this boolean will be used to check if the rabit move right
        int speed = 10; // this is the default speed for the Vegetable Dropping
        int score = 0; // this is the default player score value
        int missed = 0; // this is the default miss value
        int second = 1000;//Time duration of the game
        public static bool gameTimerState;//game timer Enable state checking

        Random rndY = new Random(); //this will be used to generate a random Y location
        Random rndX = new Random(); // this will be used to generate a random X location
        PictureBox splash = new PictureBox(); // create a new splash picture box, this will added dynamically

        public static bool con_btn_state;
        public static int HeighSocre;
        //public static bool tmrEnabling = true;
        





        public Game_Window()
        {
            InitializeComponent();
            
            
            GameRestart();
        }

        private void Key_Is_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                // if the left key is pressed change the go left to true
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                // if the right key is pressed change the go right to true
                goright = true;
            }
        }

        private void Key_Is_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                // if the left key is releas then change the go left to false
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                // if the right key is release then change the go right to false
                goright = false;
            }
        }

        private void Main_Game_Timer(object sender, EventArgs e)
        {
            gameTimerState = true;
            

            lblScore.Text = "Score    :   " + score; // show the score on vegetables Caught label
            lblMissed.Text = "Missed  :   " + missed; // Show the misses on vegetables Missed label


            lblTimer.Text = "Timer : " + second--.ToString(); // Showing the Timer CountDown on the lablel



            // if the go left boolean is true AND rabit picturebox left border is greater than 0px

            if (goleft == true && rabit.Left > 0)
            {

                if (score > 20)
                {

                    // score is grater than 20, then we move the rabit 30 pixels to the left
                    rabit.Left -= 30;
                    //rabit image will be change to the one moving left
                    rabit.Image = Properties.Resources.rabit_normal2;
                }
                else
                {
                    // score is less than 20, then we move the rabit 20 pixels to the left
                    rabit.Left -= 20;
                    //rabit image will be change to the one moving left side image
                    rabit.Image = Properties.Resources.rabit_normal2;
                }

 
            }
            //if the go right is true AND rabit picturebox width and picture box left border is less than form width
            // meaning the rabit is still within the frame of the game
            if (goright == true && rabit.Left + rabit.Width < this.ClientSize.Width)
            {
                if(score > 20)
                {
                    // move the rabit 30 pixels to the right
                    rabit.Left += 30;
                    // change the rabit image to the one moving right side image
                    rabit.Image = Properties.Resources.rabit_normal;
                }
                else
                {
                    // move the chicken 20 pixels to the right
                    rabit.Left += 20;
                    // change the rabit image to the one moving right side image
                    rabit.Image = Properties.Resources.rabit_normal;
                }
                

            }


            //below for loop will check the vegetaables dropping from the top
            // for each Control we are calling dropingItem in this form
            foreach (Control dropingItem in this.Controls)
            {
                // if dropingItem is a type of picture box AND it has the tag of veg
                if (dropingItem is PictureBox && dropingItem.Tag == "veg")

                {
                    // then move dropingItem towards the bottom (increasing the picturebox top border )
                    dropingItem.Top += speed;

                    // if the vegetables [dropingItem] reaches bottom of the screen
                    if (dropingItem.Top + dropingItem.Height > this.ClientSize.Height)
                    {
                        // if the vagetables hit the floor then we nees to show the splash image
                        splash.Image = Properties.Resources.splash; // set the splash image 
                        splash.Location = dropingItem.Location; // splash shows up on the same location as the vagetables dropped
                        splash.Height = 59; // set the height of the splash imagebox
                        splash.Width = 60; // set the width of the splash imagebox
                        splash.BackColor = System.Drawing.Color.Transparent; // apply transparent background to the spash picture box

                        this.Controls.Add(splash); // add the splash picture to the form

                        dropingItem.Top = rndY.Next(80, 300) * -1; // position the vegetables to a random Y location
                        dropingItem.Left = rndX.Next(5, this.ClientSize.Width - dropingItem.Width); // position the vagetables to a random X location
                        missed++; // add 1 point to the missed variable
                        rabit.Image = Properties.Resources.rabit_angry; // change the rabit image to angry rabit image
                    }

                    // if the vagetable bound with the rabit image
                    // if both picture boxes collide
                    if (dropingItem.Bounds.IntersectsWith(rabit.Bounds))
                    {
                        dropingItem.Top = rndY.Next(100, 300) * -1; // position the vagetable to a random Y location
                        dropingItem.Left = rndX.Next(5, this.ClientSize.Width - dropingItem.Width); // position the vegetable to a random X location
                        score++; // add 1 point to the score variable
                    }

                    // if the score is equals to or greater than 20
                    if (score >= 20)
                    {
                        speed = 15; // increase the vegetables dropping speed to 15

                    }

                    // if the missed number is greater than 20 or timer countdown equal to 0
                    // we will stop the game
                    if (second == -1 || missed == 20)
                    {

                        if (second == -1)
                        {
                            GameTimer.Stop(); // stop the game timer
                            MessageBox.Show("Your Time is Ovr..Score is :" + score);//Show the player Score
                            MessageBox.Show("Click OK to restart the Game");//Show the restart dialog
                            second = 1000;

                           /* if (score > 0)
                            {
                                HeighSocre = score;
                            }*/

                            GameRestart();
                            
                        }
                        else
                        {
                            GameTimer.Stop(); // stop the game timer
                            MessageBox.Show("Game is Over.. \n Your lost more vagetables..Score is :" + score); //Show the player Score
                            MessageBox.Show("Click OK to restart");//Show the restart dialog
                            second = 1000;

                            /*if (score > 0)
                             {
                                 HeighSocre = score;
                             }*/


                            GameRestart();
                        }





                       /* GameTimer.Stop(); // stop the game timer
                        // show the message box to say game is over. 
                        MessageBox.Show("Game Over!! You lost more vegetables" + "\r\n" + "Click OK to restart");
                        // once the players clicks OK we restart the game again
                        GameRestart();*/

                    }

                }
            }



        }

        private void GameRestart()
        {
            // check all of the controls with this loop
            // create a control called dropingItem and check it in the form components
            foreach (Control dropingItem in this.Controls)
            {
                /// if dropingItem is a picture box and it has a tag of veg
                if (dropingItem is PictureBox && dropingItem.Tag == "veg")
                {
                    // we move it to top of the screen
                    dropingItem.Top = rndY.Next(80, 300) * -1; // give it a random y location
                    dropingItem.Left = rndX.Next(5, this.ClientSize.Width - dropingItem.Width); // give it a random x location
                }
            }

            rabit.Left = this.ClientSize.Width / 2; // reset the rabit to middle of the form
            rabit.Image = Properties.Resources.rabit_normal2; // change the rabit picture to face left

            score = 0; // set score to 0
            missed = 0; // set missed to 0
            speed = 12; // set speed to 16
            second = 1000;//set the Countdown Value in to 1min


            //HeighSocre = score;

            goleft = false; // set go left to false
            goright = false; // set go right to false
            GameTimer.Start(); // start the game timer

        }



        private void btn_pause_MouseHover(object sender, EventArgs e)
        {
            /*if (btn_pause.Image == Properties.Resources.pause_normal_n)
            {
                btn_pause.Image = Properties.Resources.pause_hover_n;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
                sound.Play();
            }



            else //if (btn_pause.Image == Properties.Resources.con_normal_n)
            {
                btn_pause.Image = Properties.Resources.con_hover_n;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
                sound.Play();
            }*/


        }

        private void btn_pause_MouseLeave(object sender, EventArgs e)
        {
            /*//btn_pause.Image = Properties.Resources.pause_normal_n;

            if (btn_pause.Image == Properties.Resources.pause_hover_n)
            {
                btn_pause.Image = Properties.Resources.pause_normal_n;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
                sound.Play();
            }



            else //if (btn_pause.Image == Properties.Resources.con_hover_n)
            {
                btn_pause.Image = Properties.Resources.con_normal_n;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
                sound.Play();
            }*/

        }

        //when we hover the mouse over the goto menu button 
        private void btn_go_menu_MouseHover(object sender, EventArgs e)
        {
            //change button image in to green color button image
            btn_go_menu.Image = Properties.Resources.exit_hover_n;
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\mohom\OneDrive\Desktop\MiniGame 5 th Attampt\Mini Game Last Attampt\Mini Game Last Attampt\Resources\button_sound.wav");
            //sound.Play();
        }


        //when we leave the mouse from the goto menu button
        private void btn_go_menu_MouseLeave(object sender, EventArgs e)
        {
            //change the buttom image in to clue colour image
            btn_go_menu.Image = Properties.Resources.exit_normal_n;
            
        }


        //when we click the pause button wee need to pause the game and change the button to countinue
        private void btn_pause_Click(object sender, EventArgs e)
        {
            ////var timeVal = GameTimer.();
            //GameTimer.Stop();
            //Form1 menu = new Form1();
            //menu.ShowDialog();


            //check the timer still working 
            if (gameTimerState == true)
            {
                GameTimer.Stop();//stop the game
                gameTimerState = false;//change the timer boolien vairiable value in in to false
                btn_pause.Image = Properties.Resources.con_normal_n;//change the button picture
                
            }
            //if timer timer is still stopped
            else
            {
                GameTimer.Start(); //strtt the timer again
                gameTimerState = true; //set the boolien value in to true
                btn_pause.Image = Properties.Resources.pause_normal_n; //change the button icon to pause button
                

            }
        }


        //when we press the go menu button we need to pause the game and then go to form1
        private void btn_go_menu_Click(object sender, EventArgs e)
        {
            /*if (gameTimerState == true)
            {
                GameTimer.Stop();
                gameTimerState = false;
                //btnPause.Text = "play";
            }
            //else
            //{
            //    GameTimer.Start();
            //    gameTimerState = true;
            //    //btnPause.Text = "Pause";

            //}
            con_btn_state = true;
            Form1 menu = new Form1();
            menu.ShowDialog();*/


            // if game timer is enabled [if the game is running]
            if (gameTimerState == true)
            {
                GameTimer.Stop(); //stop the timer
                gameTimerState = false;//set the boolien value to false
                btn_pause.Image = Properties.Resources.con_normal_n; //change the pause button picturebox image 
                con_btn_state = true; //now we need to show the continue button 
                Form1 menu = new Form1(); //show the main menu
                menu.ShowDialog();
            }

            //if pause button is clicked [if the game is paused]
            else if(gameTimerState == false)
            {
                //GameTimer.Start();
                //gameTimerState = true;
                //btn_pause.Image = Properties.Resources.pause_normal_n;
                //btnPause.Text = "Pause";
                con_btn_state = true; //set continue button state again to false
                Form1 menu = new Form1(); //show the main menu
                menu.ShowDialog();



            }


        }
    }
}
