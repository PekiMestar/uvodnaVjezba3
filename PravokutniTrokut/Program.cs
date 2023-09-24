using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PravokutniTrokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

        start:

            Console.WriteLine("Unesite duljinu stranice x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu stranice y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu stranice z: ");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {

                if (z == Math.Sqrt((x * x) + (y * y)))
                {
                    Console.WriteLine("Ove stranice pripadaju pravokutnom trokutu");
                }

                else
                {
                    Console.WriteLine("Ove stranice ne pripadaju pravokutnome trokutu");
                }

            }

            else
            {
                goto start;
            }

            Console.ReadKey();
        }
    }
}