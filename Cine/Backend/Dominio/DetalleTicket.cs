using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class DetalleTicket
    {
        public double Costo { get; set; }
        public int Butaca { get; set; }
        public int Funcion { get; set; }
        public double Descuento { get; set; }
       
        public DetalleTicket(double costo, int butaca, int funcion, double descuento)
        {
            Costo = costo;
            Funcion = funcion;
            Butaca = butaca;
            Descuento = descuento;
        }

        public DetalleTicket()
        {
            Costo = 0;
            Funcion = 0;
            Butaca = 0;
            Descuento = 0;
        }
    }
}

