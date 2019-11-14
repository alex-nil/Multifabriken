using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skapar listor och hämtar klass 
            List<Bil> infoBil = new List<Bil>();
            List<Godis> infoGodis = new List<Godis>();
            List<Rör> infoRör = new List<Rör>();
            List<Havremjölk> infoHavre = new List<Havremjölk>();

            Bil bil = new Bil();
            Godis godis = new Godis();
            Rör rör = new Rör();
            Havremjölk havremjölk = new Havremjölk();
            

            //Bool för att loopa program
            bool gameOn = true;

            //Skriver ut en meny för användaren
            while (gameOn)
            {
                Console.WriteLine("Välj produkt:");
                Console.WriteLine("[1] Bil");
                Console.WriteLine("[2] Godis");
                Console.WriteLine("[3] Rör");
                Console.WriteLine("[4] Havremjölk");
                Console.WriteLine("[5] Köpta Produkter");
                Console.WriteLine("[6] Avsluta");

            //Variabel för switch    
            var usrIn = Console.ReadLine();

            //switch-meny för olika produkter
            switch (usrIn)
            {
                case "1": {
                    //BIL
                    Console.Clear();
                    Console.WriteLine("Du har valt bilar.");

                    Console.WriteLine("Mata in registreringsnummer: ");
                    bil.regNr = Console.ReadLine();

                    Console.WriteLine("Mata in färg: ");
                    bil.färg = Console.ReadLine();

                    Console.WriteLine("Mata in bilmärke: ");
                    bil.märke = Console.ReadLine();

                    //Lägger till i lista
                    infoBil.Add(bil);
                    foreach (var item in infoBil)
                    {
                        bil.färdigställ();
                    }
                    Console.ReadKey();
                    break;
                }
                case "2": {
                    //GODIS
                    Console.Clear();
                    Console.WriteLine("Du har valt godis.");

                    Console.WriteLine("Vilken Smak?");
                    godis.smak = Console.ReadLine();

                    Console.WriteLine("Antal: ");
                    godis.antal = Console.ReadLine();

                    //Lägger till i lista
                    infoGodis.Add(godis);

                    foreach (var item in infoGodis)
                    {
                        godis.färdigställ();
                    }
                    Console.ReadLine();
                    break;
                }
                case "3": {
                    //RÖR
                    Console.Clear();
                    Console.WriteLine("Du har valt rör.");

                    Console.WriteLine("Diameter: ");
                    rör.diameter = Console.ReadLine();

                    Console.WriteLine("Vilken längd: ");
                    rör.längd = Console.ReadLine();

                    //Lägger till i lista
                    infoRör.Add(rör);

                    foreach (var item in infoRör)
                    {
                        rör.färdigställ();
                    }
                    Console.ReadLine();
                    break;
                }
                case "4": {
                    //HAVREMJÖLK
                    Console.Clear();
                    Console.WriteLine("Du har valt havremjölk.");

                    Console.WriteLine("Fetthalt: ");
                    havremjölk.fetthalt = Console.ReadLine();

                    Console.WriteLine("Litermängd: ");
                    havremjölk.litermängd = Console.ReadLine();

                    //Lägger till i lista
                    infoHavre.Add(havremjölk);

                    foreach (var item in infoHavre)
                    {
                        havremjölk.färdigställ();
                    }
                    Console.ReadLine();
                    break;
                }
                case "5": {
                    Console.Clear();

                    //Skriver ut varje produkt
                    bil.färdigställ();
                    godis.färdigställ();
                    rör.färdigställ();
                    havremjölk.färdigställ();

                    Console.ReadLine();
                    break;
                }

                case "6": {
                    Console.WriteLine("Programet avslutas nu");
                    Console.ReadKey();
                    gameOn = false;
                    break;
                }
                default:
                Console.WriteLine("Fel vid inmatning, förösk igen");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            }
        }
    }
}
