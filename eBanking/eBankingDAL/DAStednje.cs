using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DAStednje
    {
        public static void getStatusiStednje(DSStednje.AktivanDataTable aktivan)
        {
            aktivan.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_GetStatusi", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(aktivan);
            }
        }

        public static void getStednje(DSStednje.StednjasDataTable stednjas, string Ime, string Prezime, DateTime OD, DateTime DO, int StatusID, int? IznosOD, int? IznosDO)
        {
            stednjas.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getStednje", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);
                cmd.Parameters.AddWithValue("@StatusID", StatusID);
                cmd.Parameters.AddWithValue("@DatumOD", OD);
                cmd.Parameters.AddWithValue("@DatumDO", DO);
                cmd.Parameters.AddWithValue("@IznosOD", IznosOD);
                cmd.Parameters.AddWithValue("@IznosDO", IznosDO);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(stednjas);
            }
        }
    }
}
