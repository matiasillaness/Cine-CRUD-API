using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class Sala
    {
        public TipoSala TipoSala { get; set; }
        

        public Sala()
        {
            TipoSala = null;
        }

        public Sala(TipoSala tipoSala)
        {
            TipoSala = tipoSala;
        }
    }
}
