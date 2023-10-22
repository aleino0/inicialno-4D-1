using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će izračunati sumu reda:
1 / 3 + 1 / 9 + 1 / 27 + . . .
Korisnik treba unijeti broj članova reda.*/


namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clanovi;
            double suma = 0;
            Console.WriteLine("Unesite koliko članova reda želite zbrojti: ");
            clanovi = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < clanovi; i++)
            {
                suma += 1 / Math.Pow(3, i);
            }
            Console.WriteLine(suma);


            Console.ReadKey();
        }
    }
}
