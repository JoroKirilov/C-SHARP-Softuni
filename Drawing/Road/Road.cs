using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Road
{
    class Road
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}", new string('.' , n) , new string ('*' , n));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*" , new string ('.' , (n - 1) - i) , new string ('.', ( n - 1) + i));
            }


            Console.WriteLine(new string ('*',  n *2));
        }

        
    }
}
