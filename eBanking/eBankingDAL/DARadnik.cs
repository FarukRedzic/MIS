using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DARadnik
    {
        public static void Login(DSRadnik.RadniksDataTable radniks, string username, string lozinka)
        {
            radniks.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("esp_Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", lozinka);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(radniks);                
            }
        }
    }
}
