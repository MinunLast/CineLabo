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

            dataGridView1.AutoGenerateColumns = false;

            // Configurar la columna para 'nombre_cine'
            DataGridViewTextBoxColumn columnaNombreCine = new DataGridViewTextBoxColumn();
            columnaNombreCine.DataPropertyName = "nombre_cine"; // Nombre de la columna en el DataTable
            columnaNombreCine.HeaderText = "Nombre del Cine";
            dataGridView1.Columns.Add(columnaNombreCine);

            // Configurar la columna para 'codigo_funcion'
            DataGridViewTextBoxColumn columnaCodigoFuncion = new DataGridViewTextBoxColumn();
            columnaCodigoFuncion.DataPropertyName = "codigo_funcion"; // Nombre de la columna en el DataTable
            columnaCodigoFuncion.HeaderText = "Código de la Función";
            dataGridView1.Columns.Add(columnaCodigoFuncion);

            // Configurar la columna para 'id_sala'
            DataGridViewTextBoxColumn columnaIdSala = new DataGridViewTextBoxColumn();
            columnaIdSala.DataPropertyName = "id_sala"; // Nombre de la columna en el DataTable
            columnaIdSala.HeaderText = "ID de la Sala";
            dataGridView1.Columns.Add(columnaIdSala);

            // Configurar la columna para 'butacas_disponibles'
            DataGridViewTextBoxColumn columnaButacasDisponibles = new DataGridViewTextBoxColumn();
            columnaButacasDisponibles.DataPropertyName = "butacas_disponibles"; // Nombre de la columna en el DataTable
            columnaButacasDisponibles.HeaderText = "Butacas Disponibles";
            dataGridView1.Columns.Add(columnaButacasDisponibles);

            // Configurar la columna para 'butacas_no_disponibles'
            DataGridViewTextBoxColumn columnaButacasNoDisponibles = new DataGridViewTextBoxColumn();
            columnaButacasNoDisponibles.DataPropertyName = "butacas_no_disponibles"; // Nombre de la columna en el DataTable
            columnaButacasNoDisponibles.HeaderText = "Butacas No Disponibles";
            dataGridView1.Columns.Add(columnaButacasNoDisponibles);

            // Llenar el DataGridView con los datos
            dataGridView1.DataSource = datosConsulta;

            // Ajusta las propiedades del DataGridView según tus necesidades
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
