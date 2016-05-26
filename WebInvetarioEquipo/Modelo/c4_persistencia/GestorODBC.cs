using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.c4_persistencia
{
    public abstract class GestorODBC
    {
        protected SqlConnection conexion;
        public abstract void abrirConexion();
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public SqlCommand prepararSentencia(string sql)
        {
            SqlCommand sentencia;
            return sentencia = new SqlCommand(sql, conexion);
        }
        public SqlDataReader ejecutarConsulta(string sql)
        {
            SqlDataReader resultado;
            SqlCommand sentencia = prepararSentencia(sql);
            resultado = sentencia.ExecuteReader();
            return resultado;
        }
    }
}
