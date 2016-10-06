using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public static class DAObavijesti
    {
        public static void getObavijesti(DSObavijesti.ObavijestsDataTable obavijests, string Ime, string Prezime, string Naslov, DateTime OD, DateTime DO)
        {
            obavijests.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getObavijesti", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);
                cmd.Parameters.AddWithValue("@Naslov", Naslov);
                cmd.Parameters.AddWithValue("@Pocetak", OD);
                cmd.Parameters.AddWithValue("@Kraj", DO);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(obavijests);
            }
        }

        public static void getObavijestByID(DSObavijesti.ObavijestsDataTable obavijests, int obavijestID)
        {
            obavijests.Clear();

            using (SqlConnection cn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("usp_getObavijestByID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ObavijestID", obavijestID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(obavijests);
            }
        }
    }
}
