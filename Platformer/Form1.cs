using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Platformer
{
    public partial class Window : Form
    {
        //Различные переменны для построения логики игры.
        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 3;
        int enemyTwoSpeed = 3;

        public Window()
        {
            InitializeComponent();
        }

        //Игровые механики.

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            scoreText.Text = "Score: " + score;
            player.Top += jumpSpeed;

            if (goLeft == true)
                player.Left -= playerSpeed;

            if (goRight == true)
                player.Left += playerSpeed;

            if (jumping == true && force < 0)
                jumping = false;

            if (jumping == true)
            {
                jumpSpeed = -6;
                force -= 1;
            }

            else
            {
                jumpSpeed = 5;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                            if ((string)x.Name == "horizontalMovingStone" && goLeft == false || (string)x.Name == "horizontalMovingStone" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                        }
                        x.BringToFront();
                    }
                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }
                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            scoreText.Text = "Score: " + score + Environment.NewLine + "You were killed in your journey!";
                        }
                    }

                    if (x.Name == "pointer" && player.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        isGameOver = true;
                        scoreText.Text = "Score: " + score + Environment.NewLine + "Your quest is complete!";
                    }
                }
            }

            enemy1.Left -= enemyOneSpeed;
            if (enemy1.Left < stone1.Left || enemy1.Left + enemy1.Width > stone1.Left + stone1.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemy2.Left += enemyTwoSpeed;
            if (enemy2.Left < stone5.Left || enemy2.Left + enemy2.Width > stone5.Left + stone5.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                isGameOver = true;
                scoreText.Text = "Score: " + score + Environment.NewLine + "You fell to your death!";
            }

            horizontalMovingStone.Left -= horizontalSpeed;
            if (horizontalMovingStone.Left > 340 || horizontalMovingStone.Left < 640)
            {
                horizontalSpeed = -horizontalSpeed;
            }
        }


        //Элементы управления.
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;

            if (e.KeyCode == Keys.Right)
                goRight = true;

            if (e.KeyCode == Keys.Space && jumping == false)
                jumping = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;

            if (e.KeyCode == Keys.Right)
                goRight = false;

            if (jumping == true)
                jumping = false;

            if (e.KeyCode == Keys.Enter && isGameOver == true)
                RestartGame();
        }
        
        //Перезапуск игры.
        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            scoreText.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            player.Left = 55;
            player.Top = 460;

            enemy1.Left = 265;
            enemy2.Left = 630;

            horizontalMovingStone.Left = 340;
            verticalMovingStone.Top = 190; 

            gameTimer.Start();
            gameTimer.Interval = 16;

        }
    }
}
