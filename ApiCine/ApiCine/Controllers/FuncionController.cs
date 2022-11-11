using Backend.Dominio;
using Backend.Servicios;
using Backend.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionController : Controller
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        
        public FuncionController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }
        
        [HttpGet("/peliculas")]
        public IActionResult GetPeliculas()
        {
            return Ok(oServicio.GetPeliculas());
        }
        
        
        [HttpPost("/crearFuncion")]
        public IActionResult PostFuncion(Funcion a)
        {
            try
            {
                if (a == null)
                    return BadRequest("error al dar de alta  la funcion");

                return Ok(oServicio.getGrabarFuncion(a));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete("/borrarFuncion")]

        public IActionResult deleteFuncion(int id)
        {
            return Ok(oServicio.getEliminarFuncion(id));
        }

        
        
        [HttpGet("/proximoTicket")]
        public IActionResult GetProximoTicket()
        {
            return Ok(oServicio.getProximoTicket());
        }

















































        //// GET: FuncionController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: FuncionController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: FuncionController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: FuncionController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FuncionController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: FuncionController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FuncionController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: FuncionController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
