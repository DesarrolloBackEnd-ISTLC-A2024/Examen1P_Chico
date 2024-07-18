using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace Examen1P_Chico.Comunes
{
    public class ConexionBD
    {
        public static SqlConnection conexion;

        public static SqlConnection abrirconexion()
        {
            conexion = new SqlConnection("Server=PC18_LAB1\\SQLEXPRESS;Database=Examen;Trusted_Connection=True;");
            conexion.Open();
            return conexion;
        }

        public static string GetFutbolista()
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = abrirconexion();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SP_GET_FUTBOLISTAS";
            cmd.CommandType = CommandType.StoredProcedure;

        }


    }

}
