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
    public partial class DetallePago : Form
    {
        private DataTable datosConsulta;

        public DetallePago(DataTable datosConsulta)
        {
            InitializeComponent();

            // Guarda el DataTable para su uso en otros métodos del formulario
            this.datosConsulta = datosConsulta;
            // Configura las columnas del DataGridView
            dataGridView1.AutoGenerateColumns = true;

            // Llenar el DataGridView con los datos
            dataGridView1.DataSource = datosConsulta;
        }

        // Puedes agregar cualquier lógica adicional según tus necesidades
        private void ResultadoConsulta_Load(object sender, EventArgs e)
        {
            // Puedes realizar acciones adicionales al cargar el formulario si es necesario
        }
    }
}
