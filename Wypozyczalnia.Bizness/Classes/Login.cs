using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    class Login
    {
        public void DataCheck(string _login, string _password)
        {
            Security passwordCheck = new Security();
            string HashPassword = passwordCheck.EncodeToSHA256(_password);

            if (_password == HashPassword)
            {
               
            }
        }
    }
}
