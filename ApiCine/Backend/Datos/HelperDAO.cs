using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dominio;

namespace Backend.Datos
{
    internal class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cine2;Integrated Security=True");
        
        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDAO();
            return instancia;
        }

        public DataTable ConsultaFiltros(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
        public DataTable Consultar(string NombreSp)
        {     
            
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSp;
            cmd.Connection = cnn;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        internal bool Ejecutar(string sp, List<Parametro> lst)
        {
            
            bool respuesta = false;
            SqlTransaction transaccion = null;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sp, cnn, transaccion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    foreach (Parametro param in lst)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                cmd.ExecuteNonQuery();

                transaccion.Commit();
                respuesta = true;
            }
            catch (Exception)
            {
                if (cnn != null)
                    transaccion.Rollback();

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return respuesta;


        }
        public int EjecutarSQL(string sp, List<Parametro> lst)
        {
           
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaccion = null;
            int filasAfectadas = 0;

            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Parameters.Clear();
                foreach (Parametro p in lst)
                {
                    cmd.Parameters.AddWithValue(p.Clave, p.Valor);
                }
                filasAfectadas = cmd.ExecuteNonQuery();
                //cnn.Close();
                return filasAfectadas;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cnn.Close();
            }
        }
        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
      
    }
}
