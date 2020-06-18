using System;
using System.Drawing;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text.Length > 15)
                {
                    throw new TooManyCharactersException("El username es demasiado largo.");
                }

                if (textBox1.Text.Equals(""))
                {
                    //MessageBox.Show("No dejar campos vacios");
                    throw new EmptyTextBoxException("Por favor introduzca un nombre de usuario");
                }
                else
                {
                    try
                    {
                        usuarDAO.crearNuevo(textBox1.Text, 0);

                        MessageBox.Show("Se ha registrado jugador","ARKANOID",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        NewGame ventana = new NewGame(textBox1.Text);
                        ventana.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
            }
            catch (EmptyTextBoxException s)
            {
                MessageBox.Show(s.Message);
            }
            catch (TooManyCharactersException x)
            {
                MessageBox.Show(x.Message, "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}