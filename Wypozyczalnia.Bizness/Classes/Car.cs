﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Bizness
{
    public class Car 
    {
        string Producent { get; set; }
        string Marka { get; set; }
        int Rocznik { get; set; }
        string Nadwozie { get; set; }
        int LiczbaDrzwi { get; set; }
        int MaxPasazerow { get; set; }
        string KolorNadwozie { get; set; }
        string DataPrzegladu { get; set; }
        string DataUbezpieczenia { get; set; }
        int Przebieg { get; set; }
        string NumerRejestracyjny { get; set; }
        string NumerVIN { get; set; }
        public int Option { get; set; }
        // 1-Nowy, 2-Edycja, 3-usun

    }
}
