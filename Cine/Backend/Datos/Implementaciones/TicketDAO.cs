using Backend.Datos.Interfaces;
using Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Datos.Implementaciones
{
    public class TicketDAO : ITicketDAO
    {
        
        public bool getConfirmarTicket(Ticket oTicket)
        {
            bool resultado = true;
            SqlTransaction trans = null;
            SqlConnection conn = HelperDAO.ObtenerInstancia().ObtenerConexion();         
            SqlCommand cmd = new SqlCommand();
            try
            {

                conn.Open();
                trans = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = trans;
                cmd.CommandText = "SP_GRABAR_TICKET";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo_pago", oTicket.Pago);
                cmd.Parameters.AddWithValue("@id_cliente", oTicket.Cliente);
                cmd.Parameters.AddWithValue("@fecha_compra", DateTime.Today);
                SqlParameter pOut = new SqlParameter();
                pOut.SqlDbType = SqlDbType.Int;
                pOut.ParameterName = "@id_ticket";
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
              
               
                foreach (DetalleTicket detalle in oTicket.Detalles)
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "SP_INSERTAR_DETALLE_TICKET";
                    comando.Connection = conn;
                    comando.Transaction = trans;        
                    comando.Parameters.AddWithValue("@id_ticket", (int)pOut.Value);
                    comando.Parameters.AddWithValue("@id_funcion", detalle.Funcion);
                    comando.Parameters.AddWithValue("@descuento", detalle.Descuento);
                    comando.Parameters.AddWithValue("@id_butaca", detalle.Butaca);
                    comando.Parameters.AddWithValue("@costo", detalle.Costo);
                    comando.ExecuteNonQuery();
                  
                }
                trans.Commit();
                
            }
            catch (Exception)
            {
                trans.Rollback();
                resultado = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return resultado;


        }











        //public int getConfirmarTicket(Ticket oTicket)
        //{
        //    bool resultado = true;
        //    SqlTransaction trans = null;
        //    SqlConnection conn = HelperDAO.ObtenerInstancia().ObtenerConexion();
        //    SqlCommand cmd = new SqlCommand();
        //    try
        //    {
        //        //conn.Open();
        //        //cmd.Parameters.Clear();
        //        //trans = conn.BeginTransaction();
        //        //cmd.Connection = conn;
        //        //cmd.Transaction = trans;
        //        //cmd.CommandText = "SP_GRABAR_TICKET";
        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("@id_tipo_pago", oTicket.Pago);
        //        //cmd.Parameters.AddWithValue("@id_cliente", oTicket.Cliente);
        //        //cmd.Parameters.AddWithValue("@fecha_compra", oTicket.Fecha);
        //        //SqlParameter pOut = new SqlParameter();
        //        //pOut.SqlDbType = SqlDbType.Int;
        //        //pOut.ParameterName = "@id_ticket";
        //        //pOut.Direction = ParameterDirection.Output;
        //        //cmd.Parameters.Add(pOut);
        //        //cmd.ExecuteNonQuery();
        //        List<Parametro> lista_parametros = new List<Parametro>();
        //        lista_parametros.Add(new Parametro("@id_tipo_pago", oTicket.Pago));
        //        lista_parametros.Add(new Parametro("@id_cliente", oTicket.Cliente));
        //        lista_parametros.Add(new Parametro("@fecha_compra", oTicket.Fecha));

        //        return HelperDAO.ObtenerInstancia().EjecutarSQL("SP_GRABAR_CLIENTE", lista_parametros);


        //        SqlCommand comando = new SqlCommand();
        //        foreach (DetalleTicket detalle in oTicket.Detalles)
        //        {

        //            comando.Parameters.Clear();
        //            comando.CommandText = "SP_INSERTAR_DETALLE_TICKET";
        //            comando.Parameters.AddWithValue("@id_ticket", 2);
        //            comando.Parameters.AddWithValue("@id_funcion", detalle.Funcion);
        //            comando.Parameters.AddWithValue("@descuento", detalle.Descuento);
        //            comando.Parameters.AddWithValue("@id_butaca", detalle.Butaca);
        //            comando.Parameters.AddWithValue("@costo", detalle.Costo);
        //            comando.ExecuteNonQuery();
        //        }
        //        trans.Commit();
        //    }
        //    catch (Exception)
        //    {
        //        trans.Rollback();
        //        resultado = false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}

        public List<Cliente> getconsultarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable dt = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTE");
            foreach(DataRow r in dt.Rows)
            {
                Cliente n = new Cliente();
                n.Id_Cliente = Convert.ToInt32(r["id_cliente"]);
                n.Nombre = (r["nom_cliente"]).ToString();
                n.Apellido = (r["ape_cliente"]).ToString();
                n.Dni = Convert.ToInt64(r["dni_cliente"]);
                n.Calle = (string)(r["calle"]);
                n.Email = (string)(r["email"]);
                n.Telefono = (long)(r["telefono"]);
                n.Altura = (int)(r["altura"]);
                clientes.Add(n);
            }
            return clientes;
        }

        public DataTable getConsultarDB(string NomProc)
        {
            throw new NotImplementedException();
        }
        
        public List<Funcion> getConsultarFunciones()
        {
            List<Funcion> funcion = new List<Funcion>();
            DataTable dt = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_FUNCIONES"); 
            foreach (DataRow r in dt.Rows)
            {                 
                Funcion n = new Funcion();
                n.Sala = Convert.ToInt32(r["id_sala"]);
                n.Id_Funcion = (int)(r["id_funcion"]);
                n.Fecha = (DateTime)(r["fecha_hora"]);
                n.Precio = Convert.ToDouble(r["pre_unitario"]);
                n.Pelicula = (int)(r["id_pelicula"]);
                //n.Activo = Convert.ToInt32(r["activo"]);
                funcion.Add(n);
            }
            return funcion;
        }

        public List<FuncionComplementaria> getConsultarFuncionesTicket()
        {
            List<FuncionComplementaria> funcion2 = new List<FuncionComplementaria>();
            DataTable dt = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_FUNCIONES3"); 
            foreach (DataRow r in dt.Rows)
            {
                FuncionComplementaria n = new FuncionComplementaria();            
                n.id_funcion = (int)(r["id_funcion"]); 
                n.Display = (string)(r["titulos"]);
                funcion2.Add(n);
            }
            return funcion2;
        }

        public List<TipoPago> getconsultarTipoPago()
        {
            List<TipoPago> lst = new List<TipoPago>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPO_PAGO"); 
            foreach (DataRow dr in tabla.Rows)
            {
                TipoPago tp = new TipoPago(); 
                tp.idTipoPago = Convert.ToInt32(dr["id_tipo_pago"]);
                tp.nombreTipo = Convert.ToString(dr["nombre_tipo_pago"]);
                lst.Add(tp);
            }
            return lst;
        }

        public DataTable getConsultarUsuarios()
        {
            DataTable tabla = new DataTable();
            SqlConnection conn = HelperDAO.ObtenerInstancia().ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "consultarUsuarios";
            tabla.Load(cmd.ExecuteReader());
            conn.Close();
            return tabla;
        }

        public bool getEliminarCliente(int idCliente)
        {
            string sp = "SP_ELIMINAR_CLIENTE";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id", idCliente));
            int afectadas = HelperDAO.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }

        public bool getEliminarFuncion(int idFuncion)
        {
            string sp = "SP_ELIMINAR_FUNCIONES";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_funcion", idFuncion));
            int afectadas = HelperDAO.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lst = new List<Pelicula>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULA");
            foreach (DataRow dr in tabla.Rows)
            {
                Pelicula p = new Pelicula();
                p.Duracion = Convert.ToInt32(dr["duracion"]);
                p.idTipoPelicula = Convert.ToInt32(dr["id_tipo"]);
                p.Titulo = (string)(dr["titulo"]);
                p.idPelicula = Convert.ToInt32(dr["id_pelicula"]);
                lst.Add(p);
            }
            return lst;
        }

        public int getGrabarCliente(Cliente oCliente)
        {
            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@dni", oCliente.Dni));
            lista_parametros.Add(new Parametro("@email", oCliente.Email));
            lista_parametros.Add(new Parametro("@calle", oCliente.Calle));
            lista_parametros.Add(new Parametro("@altura", oCliente.Altura));
            lista_parametros.Add(new Parametro("@telefono", oCliente.Telefono));
            lista_parametros.Add(new Parametro("@nombre", oCliente.Nombre));
            lista_parametros.Add(new Parametro("@apellido", oCliente.Apellido));
            return HelperDAO.ObtenerInstancia().EjecutarSQL("SP_GRABAR_CLIENTE", lista_parametros);   
        }

        public int insertarprueba(Ticket oTicket)
        {
            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@id_tipo_pago", oTicket.Pago));
            lista_parametros.Add(new Parametro("@id_cliente", oTicket.Cliente));
            lista_parametros.Add(new Parametro("@fecha_compra", oTicket.Fecha));
            

            foreach (DetalleTicket detalle in oTicket.Detalles)
            {

                List<Parametro> lista_parametross = new List<Parametro>();
                lista_parametros.Add(new Parametro("@id_ticket", 2));
                lista_parametros.Add(new Parametro("@id_funcion", detalle.Funcion));
                lista_parametros.Add(new Parametro("@descuento", detalle.Descuento));
                lista_parametros.Add(new Parametro("@id_butaca", detalle.Butaca));
                lista_parametros.Add(new Parametro("@costo", detalle.Costo));
               
                return HelperDAO.ObtenerInstancia().EjecutarSQL("SP_GRABAR_TICKET", lista_parametross);

            }         
            return HelperDAO.ObtenerInstancia().EjecutarSQL("SP_GRABAR_TICKET", lista_parametros);
        }


        public int getGrabarFuncion(Funcion oFuncion)
        {

            List<Parametro> lista_parametros = new List<Parametro>();
            lista_parametros.Add(new Parametro("@idPelicula", oFuncion.Pelicula));
            lista_parametros.Add(new Parametro("@idSala", oFuncion.Sala));
            lista_parametros.Add(new Parametro("@precio", oFuncion.Precio));
            lista_parametros.Add(new Parametro("@fecha", oFuncion.Fecha));
            return HelperDAO.ObtenerInstancia().EjecutarSQL("SP_GRABAR_FUNCION", lista_parametros);
        }

        public bool getInsertarUsuarios(Usuario oUsuario)
        {
            bool ok = true;
            SqlConnection conn = HelperDAO.ObtenerInstancia().ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertarUsuarios";
            cmd.Parameters.AddWithValue("@usuario", oUsuario.nombre);
            cmd.Parameters.AddWithValue("@contra", oUsuario.contra);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ok;
        }

        public List<Pelicula> getPeliculas()
        {
            List<Pelicula> lst = new List<Pelicula>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULA"); //REVISAR NOMBRES
            foreach (DataRow dr in tabla.Rows)
            {
                Pelicula p = new Pelicula();
                p.Duracion = Convert.ToInt32(dr["duracion"]);
                p.idTipoPelicula = Convert.ToInt32(dr["id_tipo"]);
                p.Titulo = (string)(dr["titulo"]);
                p.idPelicula = Convert.ToInt32(dr["id_pelicula"]);
                lst.Add(p);
            }
            return lst;
        }

        public int getProximoTicket()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = HelperDAO.ObtenerInstancia().ObtenerConexion();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proxTicket";
            SqlParameter param = new SqlParameter("@prox", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            int proximoId;
            if (param.Value == DBNull.Value)
            {
                proximoId = 1;
            }
            else
            {
                proximoId = Convert.ToInt32(param.Value);
            }
            cmd.Connection.Close();

            return proximoId;
        }
    }
}
