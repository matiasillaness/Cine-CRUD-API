using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class Funcion
    {
        public int Id_Funcion { get; set; }
        public int Pelicula { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
        public int Sala { get; set; }
        public int Activo { get; set; }

      

        public Funcion()
        {
            Activo = 1;
            Id_Funcion = 0;
            Pelicula = 0;
            Fecha = DateTime.Today;
            Precio = 0;
            Sala = 0;
        }
        //public Funcion

        public Funcion(int pelicula, DateTime fecha, double precio, int sala)
        {
            Pelicula = pelicula;
            Fecha = fecha;
            Precio = precio;
            Sala = sala;

        }
    }
}
