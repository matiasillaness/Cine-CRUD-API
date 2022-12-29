using Backend.Servicios.Interfaces;
using Backend.Servicios;
using Microsoft.AspNetCore.Mvc;
using Backend.Dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;

        public ClientesController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        [HttpPost("/cliente")]
        public IActionResult PostCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest("Error al dar de alta al cliente.");

                return Ok(oServicio.getGrabarCliente(cliente));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpGet("/consultarClientes")]

        public IActionResult GetClientes()
        {
            return Ok(oServicio.getconsultarClientes());
        }

        [HttpDelete("/eliminarCliente")]
        public IActionResult eliminarCliente(int id)
        {
            try
            {
                if(id == 0)
                {
                    return BadRequest("error al dar de alta  la funcion");
                }
                return Ok(oServicio.getEliminarCliente(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("/Ticket22")]
        public IActionResult PostTicket(Ticket a)
        {
            if (a == null)
                return BadRequest("ERROR AL DAR DE ALTA EL TICKET");

            else
                return Ok(oServicio.getConfirmarTicket(a));
        }
















        //// GET: api/<Clientes>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<Clientes>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<Clientes>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<Clientes>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<Clientes>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
