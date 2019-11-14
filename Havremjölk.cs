
using System;
using System.Collections.Generic;

namespace Multifabriken {
    public class Havremjölk  {
        //Variabler
        List<Havremjölk> infoHavre = new List<Havremjölk>();

        public string fetthalt;
        public string litermängd;
        public void färdigställ() {
            Console.WriteLine("Du har köpt följande havremjölk med: ");
            Console.WriteLine($"Fetthalt: {fetthalt}, Litermängd: {litermängd}");
        }
    }
}