using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Wypozyczalnia.Bizness
{
    public class Car : ICarActions
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public string Nadwozie { get; set; }
        public int LiczbaDrzwi { get; set; }
        public int MaxPasazerow { get; set; }
        public string KolorNadwozia { get; set; }
        public string DataPrzegladu { get; set; }
        public string DataUbezpieczenia { get; set; }
        public int Przebieg { get; set; }
        public string NumerRejestracyjny { get; set; }
        public string NumerVIN { get; set; }
        public int DayPrize { get; set; }
        public int WeekPrize { get; set; }
        public int MonthPrize { get; set; }
        public int YearPrize { get; set; }
        public int Car_ID { get; set; }
        public int CarData_ID { get; set; }
        DatabaseAction databaseAction = new DatabaseAction();
        public void AddCar(string _marka, string _model)
        {
            //Dodawanie samochodu, zaczynamy od zapisu do tabeli Car, sprawdzane jest tutaj czy istnieje taki pojazd, jezeli tak to nie nadpisujemy bo po co trzymać duble.
            databaseAction.SetHelper();
            string QueryId = "SELECT ID FROM Car WHERE Marka = '" + _marka + "' AND Model = '" + _model + "'";
            string Query = "INSERT INTO Car(Marka, Model) VALUES ('" + _marka + "','" + _model + "')";
            string CarExist = null;
            SqlCommand CheckIfCarExist = new SqlCommand(QueryId, databaseAction.connection);
            SqlCommand AddCar = new SqlCommand(Query, databaseAction.connection);
            databaseAction.connection.Open();
            SqlDataReader sqlDataReader = CheckIfCarExist.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CarExist = sqlDataReader["ID"].ToString();
            }
            databaseAction.connection.Close();
            if (CarExist == null)
            {
                databaseAction.connection.Open();
                AddCar.ExecuteNonQuery();
            }
            else
            {
                databaseAction.connection.Close();
            }
        }

        public void AddCarData(string _year, string _nadwozie, string _door, string _maxpeople, string _color, string _checkdate, string _insurancedate, string _przebieg, string _number, string _VIN, int _id)
        {
            string Query = "INSERT INTO CAR_DATA(Rocznik, Nadwozie, LiczbaDrzwi, MaxPasazerow, Kolor, DataPrzegladu, DataUbezpieczenia, Przebieg, NumerRejestracyjny, VIN, ID_CAR) " +
                "VALUES('" + _year + "','" + _nadwozie + "','" + _door + "','" + _maxpeople + "','" + _color + "','" + _checkdate + "','" + _insurancedate + "','" + _przebieg + "','" + _number + "','" + _VIN + "'," + _id + ")";
            databaseAction.SetHelper();
            SqlCommand AddCarData = new SqlCommand(Query, databaseAction.connection);
            databaseAction.connection.Open();
            AddCarData.ExecuteNonQuery();
            databaseAction.connection.Close();
        }

        public void AddCarPrize(string _day, string _week, string _month, string _year, int _id)
        {

            databaseAction.SetHelper();
            string Query = "INSERT INTO CAR_PRIZE(DAY,WEEK,MONTH,YEAR,ID_CAR)VALUES(" + _day + "," + _week + "," + _month + "," + _year + "," + _id + ")";
            SqlCommand AddCarPrize = new SqlCommand(Query, databaseAction.connection);
            databaseAction.connection.Open();
            AddCarPrize.ExecuteNonQuery();
            databaseAction.connection.Close();
        }
        public int GetCarID(string _marka, string _model)
        {
            int ID = 0;
            string Query = "SELECT ID FROM Car WHERE Marka = '" + _marka + "' AND Model = '" + _model + "'";
            databaseAction.SetHelper();
            SqlCommand CheckIfCarExist = new SqlCommand(Query, databaseAction.connection);
            databaseAction.connection.Open();
            SqlDataReader sqlDataReader = CheckIfCarExist.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ID = Convert.ToInt32(sqlDataReader["ID"].ToString());
            }
            databaseAction.connection.Close();
            return ID;
        }

        public List<Car> GetCarData(int _id)
        {
            List<Car> CarData = new List<Car>();
            databaseAction.SetHelper();
            int ID = 0;
            string GetCarDataQuery = "  SELECT cd.ID,Marka, Model, Rocznik, Nadwozie,LiczbaDrzwi, MaxPasazerow, Kolor, DataPrzegladu, DataUbezpieczenia, Przebieg, NumerRejestracyjny, VIN, DAY, WEEK, MONTH,YEAR, ID_CAR FROM CAR_DATA cd " +
  "JOIN Car c ON c.ID = cd.ID_CAR " +
  "JOIN CAR_PRIZE cp ON cp.ID_CARDATA = cd.ID " +
  "WHERE cd.ID = " + _id;
            SqlCommand GetCarDAtaCommand = new SqlCommand(GetCarDataQuery, databaseAction.connection);
            databaseAction.connection.Open();
            SqlDataReader ReadCarData = GetCarDAtaCommand.ExecuteReader();
            while (ReadCarData.Read())
            {
                CarData.Add(new Car()
                {
                    Marka = ReadCarData["Marka"].ToString(),
                    Model = ReadCarData["Model"].ToString(),
                    Rocznik = Convert.ToInt32(ReadCarData["Rocznik"].ToString()),
                    Nadwozie = ReadCarData["Nadwozie"].ToString(),
                    LiczbaDrzwi = Convert.ToInt32(ReadCarData["LiczbaDrzwi"].ToString()),
                    MaxPasazerow = Convert.ToInt32(ReadCarData["MaxPasazerow"].ToString()),
                    KolorNadwozia = ReadCarData["Kolor"].ToString(),
                    DataPrzegladu = ReadCarData["DataPrzegladu"].ToString(),
                    DataUbezpieczenia = ReadCarData["DataUbezpieczenia"].ToString(),
                    Przebieg = Convert.ToInt32(ReadCarData["Przebieg"].ToString()),
                    NumerRejestracyjny = ReadCarData["NumerRejestracyjny"].ToString(),
                    NumerVIN = ReadCarData["VIN"].ToString(),
                    DayPrize = Convert.ToInt32(ReadCarData["DAY"]),
                    WeekPrize = Convert.ToInt32(ReadCarData["WEEK"]),
                    MonthPrize = Convert.ToInt32(ReadCarData["MONTH"]),
                    YearPrize = Convert.ToInt32(ReadCarData["YEAR"]),
                    Car_ID = Convert.ToInt32(ReadCarData["ID_CAR"])
                });
            }
            databaseAction.connection.Close();
            return CarData;
        }

        public void DeleteCar(int _id)
        {

        }

        public void EditCar(List<Car> CarUpdateData)
        {
            DatabaseAction databaseAction = new DatabaseAction();
            databaseAction.SetHelper();
            string EditCarQuery = "UPDATE Car(Marka, Model) SET VALUES('" +CarUpdateData[0].Marka +"','"+CarUpdateData[0].Model+"') WHERE ID = "+ CarUpdateData[0].Car_ID;
            string EditCarDataQuery;
            string EditCarPrizeQuery = "UPDATE CAR_PRIZE SET DAY ="+ CarUpdateData[0].DayPrize + "  ,WEEK ="+ CarUpdateData[0].WeekPrize + "" +
                "  ,MONTH ="+CarUpdateData[0].MonthPrize+"  ,YEAR ="+ CarUpdateData[0].YearPrize + "  WHERE ID_CARDATA = "+ CarUpdateData[0].CarData_ID;
                
            SqlCommand Query = new SqlCommand(EditCarPrizeQuery, databaseAction.connection);
            databaseAction.connection.Open();
            Query.ExecuteNonQuery();
            databaseAction.connection.Close();
        }

        public void RentCar(string _query)
        { }

        public void GetBackCar(string _query)
        { }

        public void RegisterCar(string _query)
        { }

    }
}
