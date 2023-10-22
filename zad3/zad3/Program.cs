using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napišite program u kojem ćete deklarirati varijable a i b tipa int, c i d tipa double, dodijelite im vrijednosti 10, 7, 12.5 i 16.7, te izračunajte prosječnu vrijednost.


namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 7;
            double c = 12.5, d = 16.7;

            Console.WriteLine("Prosječnu vrijednost brojeva je " + (a + b + c + d) / 4);


            Console.ReadLine();

        }
    }
}
