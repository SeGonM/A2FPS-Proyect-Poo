using Microsoft.Data.SqlClient;
using System.Data;

namespace A2FPS
{
    internal class cConexion
    {
        
        static private string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\POO\Nomina Empleados\Nomina Empleados\dbClinica.mdf"";Integrated Security=True;Connect Timeout=30";

        
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);


        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }


        
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}