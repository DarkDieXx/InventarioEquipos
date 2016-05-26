using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.c4_persistencia.sqlserver
{
    public class ConexionSqlServer : GestorODBC
    {
        public override void abrirConexion()
        {
            try
            {
                string url = "";
                conexion = new SqlConnection(url);
                conexion.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
