using System;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPuntajes_Click(object sender, EventArgs e)
        {
            Scores window = new Scores();
            window.Show();
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Register windows = new Register();
            windows.Show();
        }
    }
}