using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Wypozyczalnia.Bizness
{
    class DataBaseAction : ICarActions, IClientActions
    {
        static string ConnectionString = @"Data Source=DESKTOP-AU4UUB7\SQLEXPRESS;Initial Catalog=Wypozyczalnia; Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnectionString);

        public int VeryfiLogin(string _query)
        {
            int Check = 0;
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
        public void AddCar(string _query)
        {
            int ID = 0;
            SqlCommand AddCar = new SqlCommand(_query, connection);
            AddCar.ExecuteNonQuery();

            AddCarData(ID);

        }

        public void AddCarData(int _iD)
        {


            return _iD;
        }

        public void RentCar()
        {

        }

        public void GetBackCar()
        {

        }

        public void RegisterCar()
        {

        }
        public void AddClient()
        {

        }
        public void ModyfiClient()
        {

        }

        public void DeleteClient()
        {

        }

    }
}
