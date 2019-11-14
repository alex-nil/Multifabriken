
using System;
using System.Collections.Generic;

namespace Multifabriken {
    public class Godis  {
        //Variabler och lista
        List<Godis> infoBil = new List<Godis>();

        public string smak;
        public string antal;
        public void färdigställ() {
            Console.WriteLine("Du har köpt följande godis: ");
            Console.WriteLine($"{smak}, {antal}");
        }
    }
}