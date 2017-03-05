using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class LocalElections
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            char sing = char.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (v != i)
                {
                    Console.WriteLine(new string('.', 13));
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0:00}.|.....|...", i);
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("...+-----+...");
                }
                if (v == i)
                {
                    if (sing == 'v' || sing == 'V')
                    {
                        Console.WriteLine(new string('.', 13));
                        Console.WriteLine("...+-----+...");
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine("{0:00}.|.\\./.|...", i);
                        Console.WriteLine("...|..V..|...");
                        Console.WriteLine("...+-----+...");
                    }
                    else if (sing == 'x' || sing == 'X')
                    {
                          Console.WriteLine(new string('.', 13));
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine("{0:00}.|..X..|...", i);
                    Console.WriteLine("...|./.\\.|...");
                    Console.WriteLine("...+-----+...");
                    }
                    
                }
            }
            Console.WriteLine(new string('.', 13));

        }
    }
}
