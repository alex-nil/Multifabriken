
using System;
using System.Collections.Generic;

namespace Multifabriken {
    public class Bil  {
        //Variabler
        List<Bil> infoBil = new List<Bil>();

        public string regNr;
        public string färg;
        public string märke;

        public void färdigställ() {
            Console.WriteLine("Du har köpt följande bil: ");
            Console.WriteLine($"{märke}, {färg}, {regNr}");
        }
    }
}