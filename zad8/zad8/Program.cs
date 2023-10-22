using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Fibonaccijev niz definiran je na sljedeći način:
• prvi član niza je 0
• drugi član niza je 1
• svaki sljedeći član niza jednak je zbroju prethodna dva člana
Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član Fibonaccijevog niza.
*/

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kraj;
            int niz = 0, niz1 = 1, niz2 = 0;

            Console.WriteLine("Unesi unesi broj n, te če izračunati n-ti član Fibonaccijelov niz: ");
            kraj = Convert.ToInt16(Console.ReadLine());
            if (kraj >= 1)
            {
                Console.WriteLine("\r\n" + niz2);
            }
            if (kraj >= 2)
            {
                Console.WriteLine(niz1);
            }
            for (int i = 2; i < kraj; i++)
            {
                niz = niz1 + niz2;
                niz2 = niz1;
                niz1 = niz;
                Console.WriteLine(niz);
            }
            Console.ReadLine();
        }
    }
}
