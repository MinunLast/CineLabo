using Biblioteca.Conexion;
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
    public partial class FechaInicial : Form
    {
        public FechaInicial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Asignar las letras ingresadas a las propiedades del formulario
            DateTime letraInicial = dateTimePicker1.Value;
            DateTime letraFinal = dateTimePicker2.Value;

            // Crear una instancia de la clase Conection
            Conection conexion = new Conection();

            // Realizar la consulta utilizando la clase Conection
            DataTable resultadoConsulta = conexion.ConsultarDetallePagos(letraInicial, letraFinal);

            // Crear una instancia del formulario para mostrar los resultados
            DetallePago resultadoForm = new DetallePago(resultadoConsulta);

            // Mostrar el formulario de resultados
            resultadoForm.Show();

            // Cerrar este formulario después de realizar la consulta
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
