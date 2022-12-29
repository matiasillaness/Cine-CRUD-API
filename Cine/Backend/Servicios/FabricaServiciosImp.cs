using Backend.Servicios.Implementaciones;
using Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Servicios
{
    public class FabricaServiciosImp : FabricaServicios
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
