using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    class Manager : Person
    {
        Security security = new Security();
        public void AddEmploee()
        {

        }
        public void AddCar()
        {

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
        public void AddNewEmploee()
        {
            string Password;
            Password = security.PasswordGenerate();
        }
    }
}
