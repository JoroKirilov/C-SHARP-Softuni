using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class CrismasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int tilda = 1;
            int tilda1 = 3;
            for (int i = 0; i < (n/2)+1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', (n - i)), new string('^', tilda));
                    tilda+=2;
            }
            for (int i = 0; i < (n/2) + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'' , (n-1) - i) , new string ('^' , tilda1));
                tilda1 += 2;
            }
            for (int i = 0; i < (n/2)+1; i++)
            {
                Console.WriteLine("{0}| |{0}", new string('\'', n-1));
                
            }
            Console.WriteLine("{0}" , new string ('-' , (n*2) +1));
            Console.WriteLine("on the road again 1");
        }
    }
}
