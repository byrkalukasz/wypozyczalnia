using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    class Client : Person
    {
        public string PESEL { get; set; }
        public string Miasto { get; set; }
        public string Adres { get; set; }
        public string NIP { get; set; }
        public string Kraj { get; set; }
        public string KodPocztowy { get; set; }
        public string NumerTelefonu { get; set; }
        public string FAX { get; set; }




    }
}
