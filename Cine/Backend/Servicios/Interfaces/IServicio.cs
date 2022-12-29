using Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Servicios.Interfaces
{
    public interface IServicio
    {
        DataTable getConsultarDB(string NomProc);
        bool getEliminarFuncion(int idFuncion);
        int getProximoTicket();
        List<Funcion> getConsultarFunciones();
        int getGrabarCliente(Cliente oCliente);
        int getGrabarFuncion(Funcion oFuncion);
        List<Cliente> getconsultarClientes();
        List<TipoPago> getconsultarTipoPago();
        bool getEliminarCliente(int idCliente);
        bool getConfirmarTicket(Ticket oTicket);
        DataTable getConsultarUsuarios();
        bool getInsertarUsuarios(Usuario oUsuario);
        List<Pelicula> GetPeliculas();
        
        List<FuncionComplementaria> getConsultarFuncionesTicket();
    }
}
