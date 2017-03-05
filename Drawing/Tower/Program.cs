using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int firstChar1 = 1;
            int firstChar2 = (n * 2) - 1;
            int firstChar3 = 1;
            int firstChar4 = (n * 2) - 1;
            int firstChar5 = 1;
            int firstChar6 = (n*2) - 1;
            int firstChar7 = 1;
            int firstChar8 = (n * 2) - 1;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(firstChar, n), secondChar, new string(firstChar, n * 2 - 1));

                for (int i = 0; i < n - 1; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(firstChar, (n - i) - 1), secondChar
                        , new string(firstChar, firstChar1)
                        , new string(firstChar, firstChar2 - 2));
                    firstChar1 += 2;
                    firstChar2 -= 2;
                }
                Console.WriteLine("{0}{1}{0}{1}{0}", secondChar, new string(firstChar, firstChar1));
                for (int i = 0; i < n - 1; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(firstChar, i + 1), secondChar
                        , new string(firstChar, firstChar4 - 2), new string(firstChar, firstChar3));
                    firstChar3 += 2;
                    firstChar4 -= 2;
                }
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(firstChar, n), secondChar, new string(firstChar, n * 2 - 1));

                for (int i = 0; i < n - 1; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(firstChar, (n - i) - 1), secondChar
                        , new string(firstChar, firstChar5)
                        , new string(firstChar, firstChar6 - 2));
                    firstChar5 += 2;
                    firstChar6 -= 2;
                }
                Console.WriteLine("{0}{1}{0}{1}{0}", secondChar, new string(firstChar, firstChar1));
                for (int i  = 0; i  < n -1; i ++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(firstChar, i + 1), secondChar
                        , new string(firstChar, firstChar8 - 2), new string(firstChar, firstChar7));
                    firstChar7 += 2;
                    firstChar8 -= 2;
                }
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(firstChar, n), secondChar, new string(firstChar, n * 2 - 1));
        }
    }
}
