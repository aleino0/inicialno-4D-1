using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Pojednostavljena provjera ispravnosti URL adrese registrirane u hrvatskom internetskom prostoru bila bi:
• mora počinjati s www
• mora završavati s hr
• mora sadržavati točku nakon www i prije hr
Napišite program koji će zatražiti od korisnika da unese URL adresu, te će provjeriti je li adresa napisana u ispravnom formatu.*/

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url;

            Console.WriteLine("Unesite URL: : ");
            url = Console.ReadLine();

            if (url.StartsWith("www.") && url.EndsWith(".hr"))
            {
                Console.WriteLine("Ovo je ispravni link u hrvatskom formatu.");
            }
            else
            {
                Console.WriteLine("Ovo nije ispravni link u hrvatskom formatu.");
            }



            Console.ReadKey();
        }
    }
}
