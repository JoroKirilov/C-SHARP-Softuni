using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftExamo
{
    class GrandTheftExamo
    {
        static void Main()
        {
            int attempts = int.Parse(Console.ReadLine());
            int theftSlapped = 0;
            int theftEscaped = 0;
            int packs = 0;
            int bottle = 0;
            int sumOfBeers = 0;
            for (int i = 0; i < attempts; i++)
            {
                int theft = int.Parse(Console.ReadLine());
                int beers = int.Parse(Console.ReadLine());

                if (theft > 5)
                {
                    theftSlapped += 5;
                    theftEscaped += (theft - 5);
                }
                else
                {
                    theftSlapped += theft;
                }

                sumOfBeers += beers;
            }
                    packs = sumOfBeers / 6;
                    bottle = sumOfBeers % 6;
                Console.WriteLine("{0} thieves slapped." , theftSlapped);
                Console.WriteLine("{0} thieves escaped." , theftEscaped);
                Console.WriteLine("{0} packs, {1} bottles.", packs , bottle);
            
        }
    }
}
