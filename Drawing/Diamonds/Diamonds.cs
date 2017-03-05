using System;

namespace Task03ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWidth = Console.ReadLine();
            int width = int.Parse(inputWidth);
            for (int i = width - 1; i >= -(width - 1); i--)
            {
                Console.WriteLine("{0}*{1}", new string('.', (width - 1) - Math.Abs(i)), new string('.', Math.Abs(i)));
            }
        }
    }
}