using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k = 0;

            for (i = 1; i < 103; i++)
            {
              for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }

                if (k == 2 && i % 3 == 0)
                        {
                         Console.WriteLine(i + " es primo y divisible por 3");
                        }
                else { 
                    if (k == 2)
                    {
                        Console.WriteLine(i + " es primo");
                    }

                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i + " divisible por 3");
                    }
                }

                k = 0;


                        }
            Console.ReadKey();

        }
    }
}
