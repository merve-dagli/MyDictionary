using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> games = new MyDictionary<int, string, string>();
            games.Add(15555, "Ea Pc The Sıms 4 Get To Work", "119 TL");
            games.Add(15556, "Call Of Duty 4 Modern Warfare PC", "85 TL");
            games.Add(15557, "Fifa 21 Standard Edition PC Oyun", "509 TL");
            games.Add(15558, "Star Wars Jedi Fallen Order PC Oyun", "305 TL");
            Console.WriteLine("Kaç adet oyun vardır? " +games.Count);
            games.Listing();
           
            games.Add(15559, "UK Truck Simulator PC", "37 TL");
            Console.WriteLine("Kaç adet oyun vardır? " + games.Count);
            games.Listing();
         

          
        }
      
    }
}
