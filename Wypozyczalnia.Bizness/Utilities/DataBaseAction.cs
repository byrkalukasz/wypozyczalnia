using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Wypozyczalnia.Bizness
{
    class DataBaseAction
    {
        string ConnectionString = @"Data Source=DESKTOP-AU4UUB7\SQLEXPRESS;Initial Catalog=Wypozyczalnia; Integrated Security=True";

        public int VeryfiLogin(string _query)
        {
            int Check = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_query,connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                Check = 1;
            else
            {
                //TODO : Dodanie zwiększania ilości błędnych prób logowania
                Check = 2;
            }
            return Check;
        }
    }
}
