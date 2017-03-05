using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int ggg = 0;
            foreach (char code in n)
            {
                ggg += code;
            }
            Console.WriteLine(ggg);
        }
    }
}
