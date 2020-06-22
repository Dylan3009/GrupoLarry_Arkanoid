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
            try
            {
                actualizarcontroles();
            }
            catch (HasNotPlayedGameException s)
            {
                MessageBox.Show(s.Message);
                throw;
            }
            
        }
        private void actualizarcontroles() // llenando el Data Grid View
        {
            // Realizar consulta a la base de datos
            List<usuar> lista = usuarDAO.getLista();   
            
            // Tabla (data grid view Scores)
            dgvScores.DataSource = null;
            dgvScores.DataSource = lista;
            for (int i = 0; i < lista.Count; i++)
            {
                DataGridViewRow row = dgvScores.Rows[i];
                row.Height = 44;
                this.dgvScores.Columns[0].DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgvScores.Columns[1].DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}