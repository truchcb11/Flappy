using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int Score = 0;
        bool gameOver = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Controls.Add(txt_Score);
            txt_Score.Top = 25;
            txt_Score.Left = 20;

            RestartGame();
        }

        private void GameTimeEven(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pictureBox4.Left -= pipeSpeed;
            pictureBox3.Left -= pipeSpeed;
            txt_Score.Text = "Score: " + Score;

            if (pictureBox4.Left < -150)
            {
                pictureBox4.Left = random.Next(750,1200);
                Score++;
            }
            if(pictureBox3.Left < -180)
            {
                pictureBox3.Left = random.Next(850, 1300);
                Score++;
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || 
                pictureBox1.Top < -25
                )
            {
                endGame();
            }

            if(Score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void GameKerisDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void GameKeyisUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame(); 
            }

        }

        private void endGame ()
        {
            gameOver = true;
            gametime.Stop();
            txt_Score.Text += " Game over!!! Press R to Retry";
            gameOver = true;
            RestartIm.Enabled = true;
            RestartIm.Visible = true;

        }

        private void RestartGame ()
        {
            gameOver = false;

            pictureBox1.Location = new Point(150, 317);
            pictureBox3.Left = 800;
            pictureBox4.Left = 1000;

            Score = 0;
            pipeSpeed = 8;
            txt_Score.Text = "Score: 0";
            RestartIm.Enabled = false;
            RestartIm.Visible = false;

            gametime.Start();
        }

        private void RestartClickEvent(object sender, EventArgs e)
        {
            RestartGame ();
        }
    }
}
