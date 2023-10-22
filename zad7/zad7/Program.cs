using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int prime = 2; prime < 100; prime++)
            {
                int check = 0;
                for (int i = 1; i <= prime; i++)
                {
                    if (prime % i == 0)
                    {
                        check++;
                    }
                }
                if (check == 2)
                {
                    Console.WriteLine(prime);
                }
            }
            Console.ReadLine();
        }
    }
}