using System.Data.SqlClient;

namespace ApiRedarbor.Conexion
{
    public class Conexion
    {
        public bool IsConnected()
        {
            string ConnectionString = Configuracion.AppSetting["ConnectionStrings:Connection"];

            try
            {
                SqlConnection connection = new(ConnectionString);
                connection.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
