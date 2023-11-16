using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Pelicula
    {
        public string NombrePelicula { get; set; }
        public Clasificacion Clasificacion { get; set; }
        public Categoria Categoria { get; set; }
    }
}

