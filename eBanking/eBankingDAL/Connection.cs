using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingDAL
{
    public class Connection
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.MISeBankingConnectionString);
            cn.Open();
            return cn;
        }
    }
}
