using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DALogovi
    {
        public static void getLogovi(DSLogovi.LogPrijavasDataTable logPrijavas, bool? uspjeh, string IPAdresa, string Ime,string Prezime, DateTime? OD, DateTime? DO)
        {
            logPrijavas.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getLogovi", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Uspjeh", uspjeh);
                cmd.Parameters.AddWithValue("@IPAdresa", IPAdresa);
                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);
                cmd.Parameters.AddWithValue("@Pocetak", OD);
                cmd.Parameters.AddWithValue("@Kraj", DO);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(logPrijavas);
            }
        }
    }
}
