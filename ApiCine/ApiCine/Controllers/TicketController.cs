using Backend.Servicios.Interfaces;
using Backend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Dominio;

namespace ApiCine.Controllers
{
    public class TicketController : Controller
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        

        public TicketController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        
        [HttpGet("/consultaClientes")]
        public IActionResult GetClientes()
        {
            return Ok(oServicio.getconsultarClientes());          
        }

        [HttpGet("/consultaFunciones")]
        public IActionResult GetFunciones()
        {
            return Ok(oServicio.getConsultarFunciones());
        }
        [HttpGet("/consultaFunciones2")]
        public IActionResult GetFunciones2()
        {
            return Ok(oServicio.getConsultarFuncionesTicket());
        }

        [HttpGet("/consultaTipoPago")]
        public IActionResult GetTipoPago()
        {
            return Ok(oServicio.getconsultarTipoPago());
        }
        
        
        [HttpPost("/Ticket")]
        public IActionResult PostTicket(Ticket a) //HIJO DE MIL PUTA
        {
               
            if (a == null)
                    return BadRequest("ERROR AL DAR DE ALTA EL TICKET");
               
            else
                    return Ok(oServicio.getConfirmarTicket(a));        
        
        
        }
        [HttpPut("/Ticket2")]
        public IActionResult PutTicket(Ticket a)
        {
            try
            {
                if (a == null)
                    return BadRequest("ERROR AL DAR DE ALTA EL TICKET");

                return Ok(oServicio.getConfirmarTicket(a));
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
