using System;
using System.Collections.Generic;
using System.Text;

namespace DrugaLaboratorijskaVjezba
{
    class KompleksniBrojKlasa
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojKlasa(double realniDio, double imaginarniDio)
        {
            this.RealniDio = realniDio;
            this.ImaginarniDio = imaginarniDio;
        }

        public override string ToString()
        {
            return $"({this.RealniDio}, {this.ImaginarniDio})";
        }
    }
}
