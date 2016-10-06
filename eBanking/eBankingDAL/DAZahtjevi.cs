using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DAZahtjevi
    {
        

        public static void getZahtjeve(DSZahtjevi.ZahtjevsDataTable zahtjevs, string ImeKlijenta, string PrezimeKlijenta, string ImeRadnika, string PrezimeRadnika, DateTime OD, DateTime DO, int Status, int TipZahtjeva)
        {
            zahtjevs.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getZahtjeve", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ImeKlijenta", ImeKlijenta);
                cmd.Parameters.AddWithValue("@PrezimeKlijenta", PrezimeKlijenta);
                cmd.Parameters.AddWithValue("@ImeRadnika", ImeRadnika);
                cmd.Parameters.AddWithValue("@PrezimeRadnika", PrezimeRadnika);
                cmd.Parameters.AddWithValue("@Pocetak", OD);
                cmd.Parameters.AddWithValue("@Kraj", DO);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@TipZahtjeva", TipZahtjeva);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(zahtjevs);
            }
        }

        public static void getTipoviZahtjeva(DSZahtjevi.TipZahtjevasDataTable tipZahtjevas)
        {
            tipZahtjevas.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getTipoviZahtjeva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tipZahtjevas);
            }
        }

        public static void getStatusiZahtjeva(DSZahtjevi.StatusiDataTable statusi)
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
