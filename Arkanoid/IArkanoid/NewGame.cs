using System;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }
        
        int Ball_x = 5;
        int Ball_y = 5;
        int score = 0;
        int lives = 3;
        int firstcollision = 3;
        
        private void Juegoterminado()
        {
            if (score > 13)
            {
                timer1.Stop();
                MessageBox.Show("Felicidades!", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            if (Ball.Top + Ball.Height > ClientSize.Height)
            {
                switch (lives)
                {
                    case 3:
                        lives--;
                        Controls.Remove(heart3);
                        Ball_y = -Ball_y;
                        break;
                    case 2:
                        lives--;
                        Controls.Remove(heart2);
                        Ball_y = -Ball_y;
                        break;
                    case 1:
                        lives--;
                        Controls.Remove(heart1);
                        timer1.Stop();
                        timer2.Stop();
                        MessageBox.Show("Game Over", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                        break;
                }
            }
        }
        
        private void scorecalculation()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_y = -Ball_y;
                        score++;
                        lblscore.Text = "Score :" + score;
                    }
                }
                else
                {
                    if (x is PictureBox && x.Tag == "specialblock")
                    {
                        if (Ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            Controls.Remove(x);
                            Ball_y = -Ball_y;
                            score+=5;
                            lblscore.Text = "Score :" + score;
                        }
                    }
                }
            }
        }
        
        private void Ball_movement()
        {
            Ball.Left += Ball_x;
            Ball.Top += Ball_y;
             
            if (Ball.Left + Ball.Width > ClientSize.Width || Ball.Left < 0)
            {
                Ball_x = -Ball_x;
            }

            if (Ball.Top < 0 || Ball.Bounds.IntersectsWith(lblscore.Bounds)||Ball.Bounds.IntersectsWith(lbllives.Bounds)
            ||Ball.Bounds.IntersectsWith(ptblogo.Bounds))
            {
                Ball_y = -Ball_y;
            }

            if (Ball.Bounds.IntersectsWith(player.Bounds))
            {
                Ball_y = -Ball_y;
            }
        }

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                player.Left -= 8;
            }
            if (e.KeyCode == Keys.Right && player.Right < 720)
            {
                player.Left += 8;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball_movement();
            scorecalculation();
            Juegoterminado();
        }
        
    }
}