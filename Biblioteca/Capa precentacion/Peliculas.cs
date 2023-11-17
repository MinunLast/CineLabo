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
            dataGridView1.AutoGenerateColumns = false;

            // Configurar la columna para 'nombre_pelicula'
            DataGridViewTextBoxColumn columnaNombrePelicula = new DataGridViewTextBoxColumn();
            columnaNombrePelicula.DataPropertyName = "nombre_pelicula"; // Nombre de la columna en el DataTable
            columnaNombrePelicula.HeaderText = "Nombre de la Película";
            dataGridView1.Columns.Add(columnaNombrePelicula);

            // Configurar la columna para 'fecha_inicio'
            DataGridViewTextBoxColumn columnaFechaInicio = new DataGridViewTextBoxColumn();
            columnaFechaInicio.DataPropertyName = "fecha_inicio"; // Nombre de la columna en el DataTable
            columnaFechaInicio.HeaderText = "Fecha de Inicio";
            dataGridView1.Columns.Add(columnaFechaInicio);

            // Configurar la columna para 'fecha_final'
            DataGridViewTextBoxColumn columnaFechaFinal = new DataGridViewTextBoxColumn();
            columnaFechaFinal.DataPropertyName = "fecha_final"; // Nombre de la columna en el DataTable
            columnaFechaFinal.HeaderText = "Fecha Final";
            dataGridView1.Columns.Add(columnaFechaFinal);

            // Configurar la columna para 'Clasificación'
            DataGridViewTextBoxColumn columnaClasificacion = new DataGridViewTextBoxColumn();
            columnaClasificacion.DataPropertyName = "Clasificación"; // Nombre de la columna en el DataTable
            columnaClasificacion.HeaderText = "Clasificación";
            dataGridView1.Columns.Add(columnaClasificacion);

            // Configurar la columna para 'Categoría'
            DataGridViewTextBoxColumn columnaCategoria = new DataGridViewTextBoxColumn();
            columnaCategoria.DataPropertyName = "Categoría"; // Nombre de la columna en el DataTable
            columnaCategoria.HeaderText = "Categoría";
            dataGridView1.Columns.Add(columnaCategoria);

            // Llenar el DataGridView con los datos
            dataGridView1.DataSource = datosConsulta;

            // Llama a un método para mostrar los datos en el formulario
            MostrarResultados();
        }
        private void MostrarResultados()
        {
            // Aquí puedes utilizar el DataTable (this.datosConsulta) para llenar un control de datos como un DataGridView
            dataGridView1.DataSource = datosConsulta;
            // Ajusta las propiedades del DataGridView según tus necesidades
            // Puedes, por ejemplo, ajustar el ancho de las columnas aquí si lo deseas
            dataGridView1.Columns["Pelicula"].Width = 200;
            dataGridView1.Columns["Inicio"].Width = 120;
            dataGridView1.Columns["Final"].Width = 120;
            dataGridView1.Columns["Clasificacion"].Width = 150;
            dataGridView1.Columns["Categoria"].Width = 150;
        }
    }
}
