using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStar
{
    class TheStar
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int middlePoint = 1;
            int inStarPoints = (n * 3) - 2;
            Console.WriteLine("{0}*{0}", new string('.', (n + n / 2) + 1));
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (n + n / 2) - i), new string('.', middlePoint));
                middlePoint += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', inStarPoints));
                inStarPoints -= 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', ((n / 2) - 1) - i), new string('.', n - (n / 2 + 1))
                , new string('.', i), new string('.', n));
            }
            Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', n - (n / 2)), new string('.', n / 2), new string('.', n));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{0}*{0}", new string('.', n));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n + 2));
        }
    }
}
