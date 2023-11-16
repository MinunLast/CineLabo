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
    public partial class Butacas : Form
    {
        private DataTable datosConsulta;

        public Butacas(DataTable datosConsulta)
        {
            InitializeComponent();
            this.datosConsulta = datosConsulta;
        }

        private void MostrarResultados()
        {
            // Aquí puedes utilizar el DataTable (this.datosConsulta) para llenar un control de datos como un DataGridView
            dataGridView1.DataSource = datosConsulta;
            // Ajusta las propiedades del DataGridView según tus necesidades
            // Puedes, por ejemplo, ajustar el ancho de las columnas aquí si lo deseas
            dataGridView1.Columns["Cine"].Width = 150;
            dataGridView1.Columns["Función"].Width = 150;
            dataGridView1.Columns["Sala"].Width = 120;
            dataGridView1.Columns["Disponibles"].Width = 150;
            dataGridView1.Columns["NoDisponibles"].Width = 180;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes agregar lógica adicional para manejar clics en celdas si es necesario
        }
    }

}
