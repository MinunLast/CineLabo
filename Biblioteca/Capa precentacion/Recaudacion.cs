 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Capa_precentacion
{
    public partial class Recaudacion : Form
    {
        private DataTable datosConsulta;
        public Recaudacion(DataTable datosConsulta)
        {
            InitializeComponent();


            this.datosConsulta = datosConsulta;

            dataGridView1.AutoGenerateColumns = false;


            dataGridView1.DataSource = datosConsulta;

            dataGridView1.Columns["Cine"].Width = 150;
            dataGridView1.Columns["Pelicula"].Width = 200;
            dataGridView1.Columns["Total"].Width = 120;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
