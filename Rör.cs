
using System;
using System.Collections.Generic;

namespace Multifabriken {
    public class Rör  {
        //Variabler
        List<Rör> infoRör = new List<Rör>();

        public string diameter;
        public string längd;
        public void färdigställ() {
            Console.WriteLine("Du har köpt följande rör med: ");
            Console.WriteLine($"Diameter: {diameter}, Längd: {längd}");
            
        }
    }
}




