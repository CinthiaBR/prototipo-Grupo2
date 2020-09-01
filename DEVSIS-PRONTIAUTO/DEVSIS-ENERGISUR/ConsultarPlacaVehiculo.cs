using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarPlacaVehiculo : Form
    {
        public ConsultarPlacaVehiculo()
        {
            InitializeComponent();
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }

        private void ConsultarPlacaVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void labelConsultarProducto_Click(object sender, EventArgs e)
        {

        }

        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
