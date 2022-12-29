using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public int idTipoPelicula { get; set; }
        public int idPelicula { get; set; }

        public Pelicula()
        {
            Titulo = string.Empty;
            Duracion = 0;
            idTipoPelicula = -1;
            idPelicula = -1;
        }
    }
}
