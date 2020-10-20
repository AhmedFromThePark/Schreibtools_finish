using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    class Buntstifte : Stift
    {
        //Konstruktor
        public Buntstifte(double strichstärke, ConsoleColor farbe) : base(strichstärke)
        {
            Farbe = farbe;
            Typ = "Buntstift";
        }

        //Text overriden
        public override string SchreibeText(string text)
        {
            return $"({Typ}, {Strichstärke}pt, {Farbe}) {text}";
        }
    }
}
