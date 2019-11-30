using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    public interface ICarActions
    {
        void AddCar();

        void AddCarData();

         void RentCar();

        void GetBackCar();

        void RegisterCar();

    }
}
