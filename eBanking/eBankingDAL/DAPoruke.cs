using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DAPoruke
    {
        public static void getPoruke(DSPoruke.PorukasDataTable porukas, string ImeKlijenta, string PrezimeKlijenta, string ImeRadnika, string PrezimeRadnika, DateTime OD, DateTime DO, int OdgovorenaID)
        {
            porukas.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getPoruke", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ImeKlijenta", ImeKlijenta);
                cmd.Parameters.AddWithValue("@PrezimeKlijenta", PrezimeKlijenta);
                cmd.Parameters.AddWithValue("@ImeRadnika", ImeRadnika);
                cmd.Parameters.AddWithValue("@PrezimeRadnika", PrezimeRadnika);
                cmd.Parameters.AddWithValue("@Pocetak", OD);
                cmd.Parameters.AddWithValue("@Kraj", DO);
                cmd.Parameters.AddWithValue("@OdgovorenaID", OdgovorenaID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(porukas);
            }
        }

        public static void getPorukaByPorukaID(DSPoruke.PorukasDataTable porukas, int porukaID)
        {
            porukas.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getPorukaByID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PorukaID", porukaID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(porukas);
            }
        }

        public static void getStatusiPoruke(DSPoruke.OdgovorStatusDataTable odgovorStatus)
        {
            odgovorStatus.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getOdgovorStatus", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(odgovorStatus);
            }
        }
    }
}
