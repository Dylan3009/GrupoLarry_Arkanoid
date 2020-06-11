using System;
using System.Media;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class NewGame : Form
    {
    
        private CustomPicturebox[,] cpb;
    
        public NewGame()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        int Ball_x = 5;
        int Ball_y = 5;
        int score = 0;

        private void NewGame_Load(object sender, EventArgs e)
        {
            player.Top = (Height - player.Height) - 60;
            player.Left = (Width - player.Width) - 700;
            Ball.Top = (Height - Ball.Height) - 100;
            Ball.Left = (Width - Ball.Width) - 750;
            heart1.Top = lblLives.Top + 10;
            heart1.Left = lblLives.Left + 110;
            heart2.Top = lblLives.Top + 10;
            heart2.Left = lblLives.Left + 160;
            heart3.Top = lblLives.Top + 10;
            heart3.Left = lblLives.Left + 210;
            
            Loadtiles();
        }
        
        private void Loadtiles()
        {
            int xAxis = 10;
            int yAxis = 5;

            int pbHeight = (int) (Height * 0.3) / yAxis ;
            int pbWidth = Width / xAxis;

            cpb = new CustomPicturebox[yAxis, xAxis];

            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPicturebox();

                    if (i == 0 || i==4)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    
                    //posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = (i * pbHeight) + 60;

                    if (i == 0)
                    {
                        cpb[i, j].BackgroundImage = Properties.Resources.bloque_gris;
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        cpb[i, j].Tag = "greyblinded";
                    }

                    if (i == 1)
                    {
                        cpb[i, j].BackgroundImage = Properties.Resources.bloque_rojo;
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        cpb[i, j].Tag = "block";
                    }
                    
                    if (i == 2)
                    {
                        cpb[i, j].BackgroundImage = Properties.Resources.bloque_azul;
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        cpb[i, j].Tag = "block";
                    }
                    
                    if (i == 3)
                    {
                        cpb[i, j].BackgroundImage = Properties.Resources.bloque_verde;
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        cpb[i, j].Tag = "block";
                    }
                    
                    if (i == 4)
                    {
                        cpb[i, j].BackgroundImage = Properties.Resources.bloque_amarillo;
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        cpb[i, j].Tag = "yellowblinded";
                    }

                    Controls.Add(cpb[i, j]);
                }
            }
        }
        
        private void Juegoterminado()
        {
            if (score > 89)
            {
                timer1.Stop();
                MessageBox.Show("Felicidades!", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            if (Ball.Top + Ball.Height > ClientSize.Height)
            {
                switch (Lives.live)
                {
                    case 3:
                        Lives.live--;
                        Controls.Remove(heart3);
                        Ball_y = -Ball_y;
                        break;
                    case 2:
                        Lives.live--;
                        Controls.Remove(heart2);
                        Ball_y = -Ball_y;
                        break;
                    case 1:
                        Lives.live--;
                        Controls.Remove(heart1);
                        timer1.Stop();
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
                if (x is CustomPicturebox && x.Tag == "block")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_y = -Ball_y;
                        score++;
                        lblScore.Text = "Score :" + score;
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
                            score+=3;
                            lblScore.Text = "Score :" + score;
                        }
                    }
                }
            }
        }
        
        private void blindedblock()
        {
            foreach (Control z in this.Controls)
            {
                if (z is CustomPicturebox && z.Tag == "yellowblinded")
                {
                    if (Ball.Bounds.IntersectsWith(z.Bounds))
                    {
                        Ball_y = -Ball_y;
                        z.BackgroundImage = Properties.Resources.bloque_amarillo_roto;
                        z.Tag = "specialblock";
                    }
                }

                if (z is CustomPicturebox && z.Tag == "greyblinded")
                {
                    if (Ball.Bounds.IntersectsWith(z.Bounds))
                    {
                        Ball_y = -Ball_y;
                        z.BackgroundImage = Properties.Resources.bloque_gris_roto;
                        z.Tag = "specialblock";
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

            if (Ball.Top < 0 || Ball.Bounds.IntersectsWith(lblLives.Bounds) || 
                Ball.Bounds.IntersectsWith(ptbLogo.Bounds) || Ball.Bounds.IntersectsWith(lblScore.Bounds))
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
            if (e.KeyCode == Keys.Enter) //probando
            {
                JuegoIniciado.startgame = true;
            }

            if (JuegoIniciado.startgame == true)
            {
                if (e.KeyCode == Keys.Left && player.Left > 0)
                {
                    player.Left -= 8;
                }

                if (e.KeyCode == Keys.Right && player.Right < ClientSize.Width) 
                {
                    player.Left += 8;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Left && player.Left > 0)
                    {
                        player.Left -= 8;
                        Ball.Left -= 8;
                    }

                    if (e.KeyCode == Keys.Right && player.Right < ClientSize.Width) 
                    {
                        player.Left += 8;
                        Ball.Left += 8;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scorecalculation();
            blindedblock();
            Juegoterminado();
            if (JuegoIniciado.startgame == true)
            {
                Ball_movement();
            }
        }
        
    }
}