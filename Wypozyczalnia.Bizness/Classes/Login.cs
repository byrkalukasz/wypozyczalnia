using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    public class Login
    {
        public int Status;
        public int DataCheck(string _login, string _password)
        {
            int Check = 0;
            DataBaseAction DataBaseAction = new DataBaseAction();
            Security passwordCheck = new Security();
            string HashPassword = passwordCheck.EncodeToSHA256(_password);
            Check = DataBaseAction.VeryfiLogin("SELECT COUNT(*) FROM LOGIN WHERE LOGIN = '" + _login + "' AND PASSWORD = '"+ HashPassword +"'");
            return Check;
        }
    }
}
