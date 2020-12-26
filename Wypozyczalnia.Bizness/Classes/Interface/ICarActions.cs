using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    public interface ICarActions
    {
        void AddCar(string _marka, string _model);

        void AddCarData(string _year, string _nadwozie, string _door, string _maxpeople, string _color, string _checkdate, string _insurancedate, string _przebieg, string _number, string _VIN, int _id);

        int GetCarID(string _marka, string _model);

        void AddCarPrize(string _day, string _week, string _month, string _year, int _id);

         void RentCar(string _query);

        void GetBackCar(string _query);

        void RegisterCar(string _query);

        List<Car> GetCarData(int _id);

        void EditCar(List<Car> CarUpdateData);

        void DeleteCar(int _carDataId);

    }
}
