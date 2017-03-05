using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineGlass
{
    class WineGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0 , j = n - 2 ; i < n / 2; i++ , j -= 2)
            {
                Console.WriteLine("{0}\\{1}/{0}" , new string('.' , i) , new string('*' , j ));
            }
            if (n < 12)
            {
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine("{0}||{0}" , new string('.' , n / 2 - 1));
                }
                Console.WriteLine("{0}" , new string ('-' , n));
            }
            if (n >=12)
            {
                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', n / 2 - 1));
                }
                Console.WriteLine("{0}", new string('-', n));
                Console.WriteLine("{0}", new string('-', n));
            }
        }
    }
}
