using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
    class Kugelscheiber : Stift
    {
        public Kugelscheiber(double strichstärke, ConsoleColor farbe) : base(strichstärke)
        {
            Farbe = farbe;
            Typ = "Kugelschreiber";
        }

        public override string SchreibeText(string text)
        {
            return $"({Typ}, {Strichstärke}pt, {Farbe}) {text}";
        }
    }
}
