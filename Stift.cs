using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    abstract class Stift
    {

        public double Strichstärke { get; set; }
        public ConsoleColor Farbe { get; set; }
        public string Typ { get; set; }

        public Stift(double strickstärke)
        {
            Strichstärke = strickstärke;
            Typ = "unbekannt";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Stift(ConsoleColor farbe, double strichstärke) : this(strichstärke)
        {
            Farbe = farbe;
        }

        public abstract string SchreibeText(string text);


    }
}
