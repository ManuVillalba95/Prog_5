using Microsoft.AspNetCore.Hosting.Server;
using System.Data;
using System.Data.SqlClient;

namespace Prueba_1___Prog5.Data
{
    public class DA_Movie
    {
        public DataTable Obtener() {
            SqlConnection cnn = new("Server=MANUEL\\MVILLALBA;Database=Movie;Trusted_Connection=True;");
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Get_Movies"; 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
