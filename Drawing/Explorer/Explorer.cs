using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    class Explorer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int tire = 1;
            Console.WriteLine("{0}*{0}" , new string('-' , n / 2));
            for (int i = n/2 - 1; i >= - ((n/2) - 1); i--)
            {
                Console.WriteLine("{0}*{1}*{0}" , new string ('-' , Math.Abs(i)), new string('-' , tire ) );
              
                if (i > 0 )
                {
                    tire += 2;
                }
                else if ( i <= 0  )
                {
                    tire -= 2;
                }
            }
            Console.WriteLine("{0}*{0}", new string('-', n / 2));
    
        }
    }
}
