using Backend.Datos.Implementaciones;
using Backend.Datos.Interfaces;
using Backend.Dominio;
using Backend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Servicios.Implementaciones
{
    public class Servicio : IServicio
    {
        private ITicketDAO oDao;
        public Servicio()
        {
            oDao = new TicketDAO();
        }

        public bool getConfirmarTicket(Ticket oTicket)
        {
            return oDao.getConfirmarTicket(oTicket);
        }

        public List<Cliente> getconsultarClientes()
        {
            return oDao.getconsultarClientes();
        }

        public DataTable getConsultarDB(string NomProc)
        {
            return oDao.getConsultarDB(NomProc);
        }

        public List<Funcion> getConsultarFunciones()
        {
            return oDao.getConsultarFunciones();
        }

        public List<TipoPago> getconsultarTipoPago()
        {
            return oDao.getconsultarTipoPago();
        }
        //holaaa xd
        public DataTable getConsultarUsuarios()
        {
            return oDao.getConsultarUsuarios();
        }

        public bool getEliminarCliente(int idCliente)
        {
            return oDao.getEliminarCliente(idCliente);
        }

        public bool getEliminarFuncion(int idFuncion)
        {
            return oDao.getEliminarFuncion(idFuncion);
        }

        public int getGrabarCliente(Cliente oCliente)
        {
            return oDao.getGrabarCliente(oCliente);
        }

        public int getGrabarFuncion(Funcion oFuncion)
        {
            return oDao.getGrabarFuncion(oFuncion);
        }
        public List<FuncionComplementaria> getConsultarFuncionesTicket()
        {
            return oDao.getConsultarFuncionesTicket();
        }

        public bool getInsertarUsuarios(Usuario oUsuario)
        {
            return oDao.getInsertarUsuarios(oUsuario);
        }

        public List<Pelicula> GetPeliculas()
        {
            return oDao.GetPeliculas();
        }

        public int getProximoTicket()
        {
            return oDao.getProximoTicket();
        }
    }
}
