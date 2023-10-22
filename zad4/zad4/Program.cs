using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će provjeriti jesu li vrijednosti sadržane u int varijablama x, y i z
stranice pravokutnog trokuta. U program uključite i provjeru da vrijednosti varijabli za ovakav
primjer imaju smislene vrijednosti (iznosi moraju biti veći od 0).*/

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            unos: Console.WriteLine("Unesite stranice trokuta (a, b, c)");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());
            z = Convert.ToInt16(Console.ReadLine());
            if (x > 0 && y > 0 && z > 0)
            {
                if (z == Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
                {
                    Console.WriteLine("unesene stranice čine pravokutan trokut");
                }
                else
                {
                    Console.WriteLine("unesene stranice ne čine pravokutan trokut");
                }
            }
            else
            {
                Console.WriteLine("duljine stranica moraju biti veće od 0");
                goto unos;
            }

            Console.ReadKey();
        } 
    }
}
