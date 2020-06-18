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
        
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                  //Connection.realizarAccion($"insert into usuar(username) values(" +
                  //                      $"'{textBox1.Text}')");
                  usuarDAO.crearNuevo(textBox1.Text);
                  

                    MessageBox.Show("Se ha registrado jugador");
                    
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

       
    }
}