using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriperTower
{
    class StriperTower
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + (n / 2) ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 3 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
