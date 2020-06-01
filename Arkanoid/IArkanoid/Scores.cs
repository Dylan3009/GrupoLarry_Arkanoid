using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IArkanoid
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            actualizarcontroles();
        }
        
        private void actualizarcontroles()
        {
            // Realizar consulta a la base de datos
            List<usuar> lista = usuarDAO.getLista();   
            
            // Tabla (data grid view Scores)
            dgvScores.DataSource = null;
            dgvScores.DataSource = lista;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}