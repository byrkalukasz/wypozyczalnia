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
            //Connect to database and check 
            Security passwordCheck = new Security();
            passwordCheck.EncodeToSHA256(_password);

            //Get password from database
            //porownaj  hasła
            //jezeli rowne to przejdz dalej jak nie to alert
        }
    }
}
