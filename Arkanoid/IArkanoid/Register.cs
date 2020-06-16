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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios ");
            }
            else
            {
                try
                {
                    Connection.realizarAccion($"insert into usuar values('" +
                                              $"{textBox1.Text}')");

                    MessageBox.Show("Se ha registrado jugador");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error ");
                }
            }
        }
    }
}