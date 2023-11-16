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

            this.datosConsulta = datosConsulta;

            dataGridView1.AutoGenerateColumns = false;

            // Configurar la columna para 'id_detalle_pago'
            DataGridViewTextBoxColumn columnaIdDetallePago = new DataGridViewTextBoxColumn();
            columnaIdDetallePago.DataPropertyName = "id_detalle_pago"; // Nombre de la columna en el DataTable
            columnaIdDetallePago.HeaderText = "ID Detalle Pago";
            dataGridView1.Columns.Add(columnaIdDetallePago);

            // Configurar la columna para 'id_factura'
            DataGridViewTextBoxColumn columnaIdFactura = new DataGridViewTextBoxColumn();
            columnaIdFactura.DataPropertyName = "id_factura"; // Nombre de la columna en el DataTable
            columnaIdFactura.HeaderText = "ID Factura";
            dataGridView1.Columns.Add(columnaIdFactura);

            // Configurar la columna para 'Nombre Cliente'
            DataGridViewTextBoxColumn columnaNombreCliente = new DataGridViewTextBoxColumn();
            columnaNombreCliente.DataPropertyName = "Nombre Cliente"; // Nombre de la columna en el DataTable
            columnaNombreCliente.HeaderText = "Nombre del Cliente";
            dataGridView1.Columns.Add(columnaNombreCliente);

            // Configurar la columna para 'Valor de Descuento'
            DataGridViewTextBoxColumn columnaValorDescuento = new DataGridViewTextBoxColumn();
            columnaValorDescuento.DataPropertyName = "Valor de Descuento"; // Nombre de la columna en el DataTable
            columnaValorDescuento.HeaderText = "Valor de Descuento";
            dataGridView1.Columns.Add(columnaValorDescuento);

            // Configurar la columna para 'Forma de Pago'
            DataGridViewTextBoxColumn columnaFormaPago = new DataGridViewTextBoxColumn();
            columnaFormaPago.DataPropertyName = "Forma de Pago"; // Nombre de la columna en el DataTable
            columnaFormaPago.HeaderText = "Forma de Pago";
            dataGridView1.Columns.Add(columnaFormaPago);

            // Llenar el DataGridView con los datos
            dataGridView1.DataSource = datosConsulta;

            // Ajusta las propiedades del DataGridView según tus necesidades
            dataGridView1.Columns["Pago"].Width = 150;
            dataGridView1.Columns["Factura"].Width = 150;
            dataGridView1.Columns["Cliente"].Width = 200;
            dataGridView1.Columns["Descuento"].Width = 150;
            dataGridView1.Columns["Forma"].Width = 180;
        }

        // Puedes agregar cualquier lógica adicional según tus necesidades
        private void ResultadoConsulta_Load(object sender, EventArgs e)
        {
            // Puedes realizar acciones adicionales al cargar el formulario si es necesario
        }
    }
}
