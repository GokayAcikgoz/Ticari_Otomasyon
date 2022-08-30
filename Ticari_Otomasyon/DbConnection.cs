using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    internal class DbConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=GOKAY\\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            connection.Open();

            return connection;
        }
    }
}
