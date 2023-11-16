using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Conexion
{
    internal class Conection
    {
        private string cadenaConexion = @"Data Source=DESKTOP-FN3CJJJ\SQLEXPRESS;Initial Catalog=cine;Integrated Security=True";

        public DataTable ConsultarBD(string SQLquery)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(SQLquery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        table.Load(command.ExecuteReader());
                    }
                }
            }

            return table;
        }

        public DataTable ConsultarRecaudacionTotal()
        {
            string query = @"
            SELECT
                p.nombre_pelicula AS Pelicula,
                c.nombre_cine AS Cine,
                SUM(df.precio) AS RecaudacionTotal
            FROM
                peliculas p
                JOIN funciones f ON p.codigo_pelicula = f.codigo_pelicula
                JOIN cines c ON f.codigo_cine = c.codigo_cine
                LEFT JOIN detalles_facturas df ON f.codigo_funcion = df.id_factura
            GROUP BY
                p.nombre_pelicula, c.nombre_cine
            ORDER BY
                Cine, Pelicula;
        ";

            return ConsultarBD(query);
        }



        public DataTable ConsultarButacas()
        {
            string query = @"
        SELECT
    c.nombre_cine,
    s.id_sala,
    f.codigo_funcion,
    COUNT(b.id_butaca) AS butacas_disponibles,
    (s.cantidad_butaca - COUNT(b.id_butaca)) AS butacas_no_disponibles
FROM cines c
INNER JOIN funciones f ON c.codigo_cine = f.codigo_cine
INNER JOIN salas s ON f.id_sala = s.id_sala
LEFT JOIN butacas b ON s.id_sala = b.id_sala
GROUP BY
    c.nombre_cine,
    s.id_sala,
    f.codigo_funcion,
    s.cantidad_butaca;
";

            return ConsultarBD(query);
        }
        public DataTable ConsultarDetallePagos(string letraInicial, string letraFinal)
        {
            string query = @"
        SELECT dp.id_detalle_pago, dp.id_factura, c.apellido_cliente + ' ' + c.nom_cliente AS 'Nombre Cliente', d.valor AS 'Valor de Descuento', fp.descripcion AS 'Forma de pago'
        FROM detalles_pagos dp
        JOIN facturas f ON f.id_factura = dp.id_factura
        JOIN detalles_facturas df ON df.id_factura = f.id_factura
        JOIN descuento d ON d.id_descuento = df.id_descuento
        JOIN formas_pago fp ON dp.id_forma = fp.id_forma
        JOIN clientes c ON c.id_cliente = f.id_cliente
        WHERE d.valor > 30
        AND fp.descripcion IN ('Efectivo', 'Credito')
        AND c.apellido_cliente >= @LetraInicial AND c.apellido_cliente <= @LetraFinal;
    ";

            // Utilizar un diccionario para asignar valores a los parámetros
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@LetraInicial", letraInicial);
            parametros.Add("@LetraFinal", letraFinal);

            return ConsultarBD(query, parametros);
        }

        // Método ConsultarBD actualizado para manejar parámetros
        public DataTable ConsultarBD(string SQLquery, Dictionary<string, object> parametros = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(SQLquery, connection))
                {
                    // Agregar parámetros, si los hay
                    if (parametros != null)
                    {
                        foreach (var parametro in parametros)
                        {
                            command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        table.Load(command.ExecuteReader());
                    }
                }
            }

            return table;
        }


        public DataTable ConsultarPeliculas()
        {
            string query = @"
        SELECT p.nombre_pelicula, p.fecha_inicio, p.fecha_final, c.descripcion AS 'Clasificación', ca.descripcion AS 'Categoría'
        FROM peliculas p
        JOIN clasificaciones c ON c.codigo_clasificacion = p.codigo_clasificacion
        JOIN categorias ca ON ca.codigo_categoria = p.codigo_categoria
        WHERE DATEDIFF(MONTH, p.fecha_inicio, GETDATE()) = 1
        AND DATEDIFF(YEAR, p.fecha_inicio, GETDATE()) = 0;";

            return ConsultarBD(query);
        }

    }
}
