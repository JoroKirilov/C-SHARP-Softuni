using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01CakeTycoon
{
    class CakeTycoon
    {
        static void Main()
        {
            BigInteger n = long.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            long f = long.Parse(Console.ReadLine());
            long t = long.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());

            decimal cakeBaked = Math.Floor((decimal)(f / c));
            if (cakeBaked > (decimal)n)
            {
                decimal trufflesCost = (decimal)(t * p);
                decimal cakePrice = (trufflesCost / (decimal)n) * 1.25m;
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
            }
            else
            {
                decimal flourRequired = (decimal)n * c;
                decimal kgNeeded = flourRequired - f;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakeBaked, kgNeeded);
            }
        }
    }
}
