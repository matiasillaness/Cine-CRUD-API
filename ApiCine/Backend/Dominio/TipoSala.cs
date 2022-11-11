using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    public class TipoSala
    {
        public int idTipoSala { get; set; }

        public TipoSala(int idTipoSala)
        {
            this.idTipoSala = idTipoSala;
        }

        public TipoSala()
        {
            idTipoSala = 0;
        }
    }
}
