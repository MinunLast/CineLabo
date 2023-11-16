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
    public partial class Peliculas : Form
    {
        private DataTable datosConsulta;

        public Peliculas(DataTable datosConsulta)
        {
            InitializeComponent();

            // Guarda el DataTable para su uso en otros métodos del formulario
            this.datosConsulta = datosConsulta;

            // Configurar las columnas del DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = datosConsulta;

            // Llama a un método para mostrar los datos en el formulario
            MostrarResultados();
        }

        private void MostrarResultados()
        {
            // Puedes agregar lógica adicional aquí si es necesario
            // Por ejemplo, ajustar las propiedades del DataGridView
            // o realizar otras operaciones con los datos
        }
    }
}
