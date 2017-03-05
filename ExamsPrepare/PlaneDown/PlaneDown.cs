using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneDown
{
    class PlaneDown
    {
        static void Main(string[] args)
        {
            int myPosX = int.Parse(Console.ReadLine());
            int myPosY = int.Parse(Console.ReadLine());
            int distanseToBorder = int.Parse(Console.ReadLine());
            int numOfEnemy = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEnemy; i++)
            {
                int distanseX = int.Parse(Console.ReadLine());
                int distanseY = int.Parse(Console.ReadLine());
                int disX = distanseX - myPosX;
                int disY = distanseY - myPosY;
                if (disX < 0)
                {
                    disX *= -1;
                }
                if (disY < 0)
                {
                    disY *= -1;
                }
                if (disX < distanseToBorder & disY < distanseToBorder)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", distanseX, distanseY);
                }
            }

        }
    }
}
