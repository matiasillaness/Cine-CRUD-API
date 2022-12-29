using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class TipoPago
    {
        public int idTipoPago { get; set; }

        public string nombreTipo { get; set; } 
        public TipoPago(int idTipoPago, string nombreTipo)
        {
            this.idTipoPago = idTipoPago;
            this.nombreTipo = nombreTipo;
        }
        public TipoPago()
        {
            this.idTipoPago = -1;
            this.nombreTipo = string.Empty;
        }
    }
}
