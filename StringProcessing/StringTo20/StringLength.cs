using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                        
                }
                Console.WriteLine();
            }
            if (input.Length < 20)
            {
                Console.Write(input);
                Console.WriteLine("{0}" , new string ('*' , 20 - input.Length  ));
            }
            else if (input.Length == 20)
            {
                Console.WriteLine(input);
            }
        }
    }

