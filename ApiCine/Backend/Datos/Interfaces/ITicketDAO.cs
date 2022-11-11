using Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Datos.Interfaces
{
    public interface ITicketDAO
    {
        DataTable getConsultarDB(string NomProc);
        bool getEliminarFuncion(int idFuncion);
        int getProximoTicket();
        List<Funcion> getConsultarFunciones();
        List<FuncionComplementaria> getConsultarFuncionesTicket();
        int getGrabarCliente(Cliente oCliente);
        int getGrabarFuncion(Funcion oFuncion);
        List<Cliente> getconsultarClientes();
        List<TipoPago> getconsultarTipoPago();
        bool getEliminarCliente(int idCliente);
        bool getConfirmarTicket(Ticket oTicket);
        DataTable getConsultarUsuarios();
        bool getInsertarUsuarios(Usuario oUsuario);
        List<Pelicula> GetPeliculas();
    }
}
