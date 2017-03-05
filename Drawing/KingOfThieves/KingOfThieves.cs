using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sing = 1;
            char symbol = char.Parse(Console.ReadLine());
            for (int i = n /2 ; i >= - ( n / 2); i--)
            {
                Console.WriteLine("{0}{1}{0}" , new string('-' , Math.Abs(i)) , new string(symbol , sing));
                if (sing < n &&  i > 0)
                {
                    sing += 2;
                }
                else
                {
                    sing -= 2;
                }
            }
        }
    }
}
