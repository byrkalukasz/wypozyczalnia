﻿using System;
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
        public int AddCar(string _query)
        {
            int ID = 0;
            SqlCommand AddCar = new SqlCommand(_query, connection);

            return ID;
        }

        public void AddCarData()
        {

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
