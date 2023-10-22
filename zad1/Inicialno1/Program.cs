using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Napišite program u kojem ćete deklarirati varijable a i b tipa int, te im dodijelite vrijednosti 100 (a) i 3 (b). Ispišite njihove vrijednosti u sljedećem obliku:
“a dijeljeno s b je x i ostatak y”.*/


namespace Inicialno1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 100, b = 3, x;
            double y;

            x = a / b;
            y = a % b;

            Console.WriteLine("a dijeljeno s b je: " + x + "\nostatak: " + y);
            Console.ReadKey();
        }
    }
}
