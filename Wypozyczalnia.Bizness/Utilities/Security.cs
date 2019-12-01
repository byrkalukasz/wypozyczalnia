using System;
using System.Text;
using System.Security.Cryptography;
namespace Wypozyczalnia.Bizness
{
    class Security
    {
        public string EncodeToSHA256(string _password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(_password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public string PasswordGenerate()
        {
            string Password = null;


            return Password;
        }
    }
}
