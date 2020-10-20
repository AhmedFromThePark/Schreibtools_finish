using Schreibtools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace Schreibtools
{
    class Program
    {
        static void Main(string[] args)
        {


            Kugelscheiber k1 = new Kugelscheiber(2, ConsoleColor.Red);
            Kugelscheiber k2 = new Kugelscheiber(4, ConsoleColor.Green);

            Buntstifte b1 = new Buntstifte(5, ConsoleColor.Cyan);
            Buntstifte b2 = new Buntstifte(3, ConsoleColor.White);


            List<Stift> Stifte = new List<Stift>();
            Stifte.Add(k1);
            Stifte.Add(k2);
            Stifte.Add(b1);
            Stifte.Add(b2);


            foreach (var item in Stifte)
            {
                Console.ForegroundColor = item.Farbe;
                Console.WriteLine($"({item.Typ}, {item.Strichstärke}pt, {item.Farbe}) ");
            }
            Console.WriteLine();
            foreach (var item in Stifte)
            {
                Console.ForegroundColor = item.Farbe;
                Console.WriteLine($"{item.SchreibeText("3CHIT")}, {txtgen()}");
            }
        }

        public static string txtgen()
        {
            string[] txt = new string[] { "Air", "Freeze", "Cai", "Lachmacun", "Chillig" };
            string bum = "";
            var rand = new Random();

            for (int i = 0; i < txt.Length; i++)
            {
                bum += txt[rand.Next(0, 5)] + " ";
            }
            return bum;
        }
    }
}