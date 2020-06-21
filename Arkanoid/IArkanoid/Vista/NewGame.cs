using System;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class NewGame : Form
    {
        private CustomPicturebox[,] cpb;
        private string prueba;
    
        public NewGame(string username)
        {
            InitializeComponent();
            Height = ClientSize.Height; // Inicializando tamano de la ventana
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            prueba = username;
        }
        
        private void NewGame_Load(object sender, EventArgs e)
        {
            player.Top = (Height - player.Height) - 60;  //posicionando los label Score y Lives también
            player.Left = (Width - player.Width) - 700;  // el PictureBox con el logo y los Corazones
            Ball.Top = (Height - Ball.Height) - 100;
            Ball.Left = (Width - Ball.Width) - 750;
            heart1.Top = lblLives.Top + 10;            
            heart1.Left = lblLives.Left + 110;
            heart2.Top = lblLives.Top + 10;
            heart2.Left = lblLives.Left + 160;
            heart3.Top = lblLives.Top + 10;
            heart3.Left = lblLives.Left + 210;
            lblEnter.Top = picLogo.Top + 500;
            lblEnter.Left = picLogo.Left + 450;
            
            Loadtiles();
        }
        
        private void Loadtiles() //Carga los bloques en pantalla
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
                    
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;
                    
                    //posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = (i * pbHeight) + 60;
                    
                    // Poniendole imagen y tag dependiendo de la fila
                    switch (i)
                    {
                        case 0:
                            cpb[i, j].BackgroundImage = Properties.Resources.bloque_gris;
                            cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            cpb[i, j].Tag = "greyblinded";
                            break;
                        case 1:
                            cpb[i, j].BackgroundImage = Properties.Resources.bloque_rojo;
                            cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            cpb[i, j].Tag = "block";
                            break;
                        case 2:
                            cpb[i, j].BackgroundImage = Properties.Resources.bloque_azul;
                            cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            cpb[i, j].Tag = "block";
                            break;
                        case 3:
                            cpb[i, j].BackgroundImage = Properties.Resources.bloque_verde;
                            cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            cpb[i, j].Tag = "block";
                            break;
                        case 4:
                            cpb[i, j].BackgroundImage = Properties.Resources.bloque_amarillo;
                            cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                            cpb[i, j].Tag = "yellowblinded";
                            break;
                    }
                    
                    Controls.Add(cpb[i, j]);
                }
            }
        }
        
        private void Juegoterminado()
        {
            if (DatosJuego.score > 89)
            {
                timer1.Stop();
                MessageBox.Show("Felicidades!", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarDAO.actualizarpuntaje(DatosJuego.score,prueba); // Se almacena el puntaje en la base de datos
                Application.Exit();
            }
            
            
            if (Ball.Top + Ball.Height > ClientSize.Height) // verificando si la pelota toco el fondo 
                {
                    switch (Lives.live) //verificando la cantidad de vidas
                    {
                        case 3:
                            Lives.live--;
                            Controls.Remove(heart3);                 
                            DatosJuego.y_move = -DatosJuego.y_move;  
                            break;
                        case 2:
                            Lives.live--;
                            Controls.Remove(heart2);
                            DatosJuego.y_move = -DatosJuego.y_move; // si tiene 3 o 2 vidas y la pelota toca el fondo 
                            break;                                  // se le reducen las vidas pero si solo tiene una
                        case 1:                                     // vida y la pelota toca el fondo se regresa a la 
                            try                                     // ventana principal
                            {
                                Lives.live--;
                                Controls.Remove(heart1);
                                timer1.Stop();
                                if (Lives.live == 0)
                                {
                                    throw new NoRemainingLivesException("Game Over");
                                }
                            }
                            catch (NoRemainingLivesException ex)
                            {
                                MessageBox.Show(ex.Message,"ARKANOID",MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            usuarDAO.actualizarpuntaje(DatosJuego.score, prueba); // se almecana el puntaje en la base 
                            this.Close();                                         // de datos
                            break;
                    }
                }
        }
        
        private void Scorecalculation() // calculando el puntaje
        {
            foreach (Control x in this.Controls)
            {
                if (x is CustomPicturebox && x.Tag == "block")    // Si el tag del bloque con el que la pelota
                {                                                 // colisiona es: "block" el score se incrementa en 1
                    if (Ball.Bounds.IntersectsWith(x.Bounds))     // y el bloque se elimina de controls
                    {
                        Controls.Remove(x);
                        DatosJuego.y_move = -DatosJuego.y_move;
                        DatosJuego.score++;
                        lblScore.Text = "Score :" + DatosJuego.score;
                    }
                }
                else
                {
                    if (x is PictureBox && x.Tag == "specialblock") // Si el tag del bloque con el que la pelota
                    {                                               // colisiona es: "specialblock" el score se
                        if (Ball.Bounds.IntersectsWith(x.Bounds))   //incrementa en 3 y el bloque se elimina de controls
                        {
                            Controls.Remove(x);
                            DatosJuego.y_move = -DatosJuego.y_move;
                            DatosJuego.score+=3;
                            lblScore.Text = "Score :" + DatosJuego.score;
                        }
                    }
                }
            }
        }
        
        private void Blindedblock() //cambia la imagen para los bloques blindados
        {
            foreach (Control z in this.Controls)
            {
                if (z is CustomPicturebox && z.Tag == "yellowblinded")  
                {                                                      
                    if (Ball.Bounds.IntersectsWith(z.Bounds))
                    {
                        DatosJuego.y_move = -DatosJuego.y_move;
                        z.BackgroundImage = Properties.Resources.bloque_amarillo_roto;
                        z.Tag = "specialblock";
                    }
                }

                if (z is CustomPicturebox && z.Tag == "greyblinded")
                {
                    if (Ball.Bounds.IntersectsWith(z.Bounds))
                    {
                        DatosJuego.y_move = -DatosJuego.y_move;
                        z.BackgroundImage = Properties.Resources.bloque_gris_roto;
                        z.Tag = "specialblock";
                    }
                }
            }
        }
        
        private void Ball_movement() //movimiento de pelota
        {
            Ball.Left += DatosJuego.x_move;
            Ball.Top += DatosJuego.y_move;
             
            if (Ball.Left + Ball.Width > ClientSize.Width || Ball.Left < 0)
            {                                               // si la pelota colisiona con el extremo derecho o izquierdo
                DatosJuego.x_move = -DatosJuego.x_move;     // de la pantalla se cambia la dirección en x
            }

            if (Ball.Top < 0 || Ball.Bounds.IntersectsWith(lblLives.Bounds) || 
                Ball.Bounds.IntersectsWith(picLogo.Bounds) || Ball.Bounds.IntersectsWith(lblScore.Bounds))
            {
                DatosJuego.y_move = -DatosJuego.y_move;    // Si la pelota colisiona con los elementos que estan arriba
            }                                              // se cambia la dirección en y 

            if (Ball.Bounds.IntersectsWith(player.Bounds)) // Si la pelota colisiona con el jugador se cambia la 
            {                                              // dirección en y
                DatosJuego.y_move = -DatosJuego.y_move;
            }
        }

        private void NewGame_KeyDown(object sender, KeyEventArgs e)
        {
            try
           {
               switch (e.KeyCode)
               {
                   case Keys.Enter:                    // Cuando el usuario presiona Enter DatosJuego cambia de
                       DatosJuego.startgame = true;    // valor a true y el juego inicia
                       Controls.Remove(lblEnter);
                       break;
                   case Keys.Right:
                       break;
                   case Keys.Left:
                       break;
                   default:
                       throw new OtherKeyException("Presiona Enter para iniciar el juego.");
                       break;
               }
           }
           catch (OtherKeyException o)
           {
               MessageBox.Show(o.Message,"ARKANOID",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }

           if (DatosJuego.startgame == true) // El player se mueve con las teclas Right y Left
            {
                if (e.KeyCode == Keys.Left && player.Left > 0)
                {
                    player.Left -= 11;
                }

                if (e.KeyCode == Keys.Right && player.Right < ClientSize.Width) 
                {
                    player.Left += 11;
                }
            }
            else  // Si no se ha presionado la tecla enter la pelota se movera junto al player con las teclas
                  // Right y Left
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
            Scorecalculation();
            Blindedblock();
            Juegoterminado();
            if (DatosJuego.startgame == true)
            {
                Ball_movement();
            }
        }
        
    }
}