using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DAKlijent
    {
        public static void getStatusi(DSKlijent.AktivanDataTable aktivan)
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

        public static void getKlijenti(DSKlijent.KlijentsDataTable klijents, int cbxAktivan, string Ime, string Prezime)
        {
            klijents.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getKlijenti", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AktivanID", cbxAktivan);
                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(klijents);
            }
        }

        public static void getTransakcijeByRacunID(DSKlijent.TransakcijasDataTable transakcijas, int racunID)
        {
            transakcijas.Clear();
            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getTransakcijeByRacunID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RacunID", racunID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(transakcijas);
            }

        }

        public static void getRacuneByKlijentID(DSKlijent.RacunsDataTable racuns, int klijentID)
        {
            racuns.Clear();
            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getRacuniByKlijentID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@KlijentID", klijentID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(racuns);
            }

        }
    }
}
