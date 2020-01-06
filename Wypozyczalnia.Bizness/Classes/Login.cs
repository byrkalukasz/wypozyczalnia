using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    public class Login
    {
        public bool ValidateCredentials(string _login, string _password)
        {
            DatabaseAction DataBaseAction = new DatabaseAction();
            Security passwordCheck = new Security();

            string HashPassword = passwordCheck.EncodeToSHA256(_password);
            string Query = "SELECT COUNT(*) FROM USERD WHERE LOGIN = '" + _login + "' AND PASSWORD = '" + HashPassword + "'";
            bool Check = DataBaseAction.ValidateLogin(Query, _login);
            return Check;
        }
    }
}
