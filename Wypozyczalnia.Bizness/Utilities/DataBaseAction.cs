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
        //string ConnectionString = @"Data Source=DESKTOP-AU4UUB7\SQLEXPRESS;Initial Catalog=Wypozyczalnia; Integrated Security=True";
        string ConnectionString = @"Server=sql7.freesqldatabase.com;Initial Catalog=sql7315545; Integrated Security=True; User ID=sql7315545;Password=8nTGDuv9sh";
        //string ConnectionString = @"User ID=*****;Password=*****;Initial Catalog=AdventureWorks;Server=MySqlServer"";
        /*
         * Darmowa baza danych postawiona na :
         * Login: mikel.19952@gmail.com
         * Hasło: gd36078gd36078
         * Database Host: sql7.freesqldatabase.com
         * Database Name: sql7315545
         * Database Username: sql7315545
         * Database Password: 8nTGDuv9sh
         * Port number: 3306
         * phpMyAdmin: 
         */

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
