using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DAUplatnice
    {
        
        public static void getUplatniceByID(DSUplatnice.UplatnicasDataTable uplatnicas, int klijentID, string Ime, string Prezime, int StatusID, DateTime OD, DateTime DO, int? IznosOD, int? IznosDO)
        {
            uplatnicas.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getUplatniceByID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@KlijentID", klijentID);
                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);
                cmd.Parameters.AddWithValue("@StatusID", StatusID);
                cmd.Parameters.AddWithValue("@DatumOD", OD);
                cmd.Parameters.AddWithValue("@DatumDO", DO);
                cmd.Parameters.AddWithValue("@IznosOD", IznosOD);
                cmd.Parameters.AddWithValue("@IznosDO", IznosDO);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(uplatnicas);
            }
        }

        public static void getStatusi(DSUplatnice.StatusiDataTable statusi)
        {
            statusi.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getStatusiZahtjeva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(statusi);
            }
        }
    }
}
