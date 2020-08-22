using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_ConexionSQL
    {
        private SqlConnection ConexionBaseDatos = new SqlConnection("Server = DESKTOP-8ES98D2; DataBase = BaseDatosTecnoStore; Integrated Security = true");

        public SqlConnection AbrirConexion()
        {
            if (ConexionBaseDatos.State == ConnectionState.Closed)
                ConexionBaseDatos.Open();
            return ConexionBaseDatos;
        }
        public SqlConnection CerrarConexion()
        {
            if (ConexionBaseDatos.State == ConnectionState.Open)
                ConexionBaseDatos.Close();
            return ConexionBaseDatos;
        }
    }
}

