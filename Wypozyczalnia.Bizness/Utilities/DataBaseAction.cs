using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Wypozyczalnia.Bizness
{
    class DatabaseAction
    {
        SqlConnection connection;
        DataTable datatable;
        public string ConnectionString = @"Data Source=DESKTOP-AU4UUB7\SQLEXPRESS;Initial Catalog=Wypozyczalnia;Integrated Security=True";

        public bool ValidateLogin(string _query, string _login)
        {
            SetHelper();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_query, connection);
            dataAdapter.Fill(datatable);
            try
            {
                if (datatable.Rows[0][0].ToString() == "1")
                {
                    bool Blocked = CheckIfAccountIsBlock(_login);
                    if (Blocked == false)
                    {
                        ClearInvalidAttempt(_login);
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    AddInValidAttempts(_login);
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public bool CheckIfAccountIsBlock(string _login)
        {
            SetHelper();
            string Query = "SELECT * FROM USERD WHERE LOGIN = '" + _login + "' AND ACCOUT_BLOCK = 1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, connection);
            dataAdapter.Fill(datatable);
            try
            {
                if (datatable.Rows[0][0].ToString() == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public void ClearInvalidAttempt(string _login)
        {
            string Query = "UPDATE USERD SET INVALID_LOGIN_ATTEMPTS = 0 WHERE LOGIN = '" + _login + "'";
            SetHelper();
            SqlCommand clear = new SqlCommand(Query, connection);
            connection.Open();
            clear.ExecuteNonQuery();
            connection.Close();

        }

        public void AddInValidAttempts(string _login)
        {
            string ChecQuery = "SELECT INVALID_LOGIN_ATTEMPTS FROM USERD WHERE LOGIN = '" + _login + "'";
            int NewValue = 0, CurrentValue;
            string value = null;

            SetHelper();
            SqlCommand command = new SqlCommand(ChecQuery, connection);
            connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                value = sqlDataReader["INVALID_LOGIN_ATTEMPTS"].ToString();
            }
            CurrentValue = Convert.ToInt32(value);
            NewValue = CurrentValue + 1;
            connection.Close();
            string AddingQuery = "UPDATE USERD SET INVALID_LOGIN_ATTEMPTS = " + NewValue + " WHERE LOGIN = '" + _login + "'";
            SqlCommand Addcommand = new SqlCommand(AddingQuery, connection);
            connection.Open();
            Addcommand.ExecuteNonQuery();
            if (NewValue == 3)
            {
                BlockAccount(_login);
            }


        }

        public void BlockAccount(string _login)
        {
            string Query = "UPDATE USERD SET ACCOUT_BLOCK = 1 WHERE LOGIN = '" + _login + "'";
            SetHelper();
            SqlCommand block = new SqlCommand(Query, connection);
            connection.Open();
            block.ExecuteNonQuery();
            connection.Close();
        }

        public int CheckId(string _login)
        {
            int ID = 0;

            return ID;
        }

        public void SetHelper()
        {
            connection = new SqlConnection(ConnectionString);
            datatable = new DataTable();
        }
    }
}
