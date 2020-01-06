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
        DataBaseAction DataBaseAction = new DataBaseAction();

        public int DataCheck(string _login, string _password)
        {

            int Check = 0;
            Security passwordCheck = new Security();
            string HashPassword = passwordCheck.EncodeToSHA256(_password);
            Check = DataBaseAction.VeryfiLogin("SELECT COUNT(*) FROM LOGIN WHERE LOGIN = '" + _login + "' AND PASSWORD = '"+ HashPassword +"'");
            if (Check != 1)
                IncorrectLogin(_login);
            return Check;
        }

        public int CheckIncorrectAttempt()
        {

        }

        public void IncorrectLogin(string _login)
        {
            //Get 
            DataBaseAction.AddIncorrectAttempts(_login);
        }
    }
}
