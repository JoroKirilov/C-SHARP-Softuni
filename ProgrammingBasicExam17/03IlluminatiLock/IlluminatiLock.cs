using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dots = 0;
            int dotsOne = 1;
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
            Console.WriteLine("{0}###{0}###{0}" , new string('.' , n -2));
            for (int i = 0 , m = 2; i < (n / 2) - 1; i++ , m+=2)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}" , new string('.' , n -4 + dots ) , new string('.' , m) , new string('.' , n -2 ));
                dots -= 2;
            }
            for (int i = 0 , m = 0; i < (n / 2) - 1; i++ , m += 2)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}" , new string('.', dotsOne ) , new string('.' , n -3 - m) , new string('.' , n - 2));
                dotsOne += 2;
            }
            Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

        }
    }
}
