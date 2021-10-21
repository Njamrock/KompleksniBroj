using System;

namespace DrugaLaboratorijskaVjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            KompleksniBrojKlasa kbk1 = new KompleksniBrojKlasa(2, 4);
            KompleksniBrojStruktura kbs1 = new KompleksniBrojStruktura(3, 5);

            KompleksniBrojKlasa kbk2 = kbk1;
            KompleksniBrojStruktura kbs2 = kbs1;


            Console.WriteLine($"kbk1={kbk1}");
            Console.WriteLine($"kbk2={kbk2}");
            Console.WriteLine($"kbs1={kbs1}");
            Console.WriteLine($"kbs2={kbs2}");

            kbk2.RealniDio = 25;
            kbs2.ImaginarniDio = 58;
            Console.WriteLine();

            Console.WriteLine($"kbk1={kbk1}");
            Console.WriteLine($"kbk2={kbk2}");
            Console.WriteLine($"kbs1={kbs1}");
            Console.WriteLine($"kbs2={kbs2}");
            Console.ReadKey(false);
        }
    }
}
