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
            Security passwordCheck = new Security();
            string HashPassword = passwordCheck.EncodeToSHA256(_password);

            if (_password == HashPassword)
            {
                Status = 2;
                return Status;
            }
            else
            {
                Status = 2;
                return Status;
            }

        }
    }
}
