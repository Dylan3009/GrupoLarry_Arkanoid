using System;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }
  
        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUser.Text.Length > 15)
                {
                    throw new TooManyCharactersException("El username es demasiado largo.");
                }

                if (txtUser.Text.Equals(""))
                {
                    //MessageBox.Show("No dejar campos vacios");
                    throw new EmptyTextBoxException("Por favor introduzca un nombre de usuario");
                }
                else
                {
                    try
                    {
                        usuarDAO.crearNuevo(txtUser.Text, 0);

                        MessageBox.Show("Se ha registrado jugador","ARKANOID",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        NewGame ventana = new NewGame(txtUser.Text);
                        ventana.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Username no disponible","ARKANOID",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (EmptyTextBoxException s)
            {
                MessageBox.Show(s.Message,"ARKANOID",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (TooManyCharactersException x)
            {
                MessageBox.Show(x.Message, "ARKANOID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}