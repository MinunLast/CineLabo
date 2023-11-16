using Biblioteca.Clases;
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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conection conexion = new Conection();
            DataTable resultadoConsulta = conexion.ConsultarRecaudacionTotal();

            // Crear una instancia del nuevo formulario y pasarle el DataTable como parámetro
            Recaudacion nuevoForm = new Recaudacion(resultadoConsulta);

            // Mostrar el nuevo formulario
            nuevoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conection conexion = new Conection();
            DataTable resultadoConsulta = conexion.ConsultarButacas();
            // Crear una instancia del nuevo formulario y pasarle el DataTable como parámetro
            Butacas nuevoForm = new Butacas(resultadoConsulta);

            // Mostrar el nuevo formulario
            nuevoForm.Show();
        }





        private void button4_Click(object sender, EventArgs e)
        {
            IngresarParametrosLetras nuevoForm = new IngresarParametrosLetras();
            nuevoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conection conexion = new Conection();
            DataTable resultadoConsulta = conexion.ConsultarPeliculas();

            Peliculas resultadoForm = new Peliculas(resultadoConsulta);
            resultadoForm.Show();
        }
    }
}
