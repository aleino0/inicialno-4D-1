using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će definirati niz tipa int, te će ga predefinirati, odnosno sortirati tako da članovi budu poredani od manjeg prema većem.
 Program mora raditi ispravno za proizvoljni broj članova niza. Članove niza na kraju ispišite.*/

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = { 15, 66, 2, 31, 6, 785, 33, 76, 77, 12 };
            Console.Write("Ne sortiran niz: ");
            for (int i = 0; i < niz.Length - 1; i++)
            {
                Console.Write(niz[i] + ", ");
            }
            for (int i = 0; i < niz.Length; i++)
            {
                for (int j = 0; j < niz.Length - i - 1; j++)
                {
                    if (niz[j] > niz[j + 1])
                    {
                        int tempInt = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j + 1] = tempInt;
                    }

                }
            }
            Console.Write("\r\n\r\nSortiran niz: ");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(niz[i] + ", ");
            }


            Console.ReadLine();

        }
    }
}
