using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sudoku
{
    class Program
    {
        static void Main()
        {
            int games = 0;
            int allSeconds = 0;
            while (true)
            {
                string timePerGame = Console.ReadLine();
                if (timePerGame == "Quit")
                {
                    break;
                }
               else
                {
                    int minutes = int.Parse(timePerGame.Substring(0, 2));
                    int seconds = int.Parse(timePerGame.Substring(3, 2));
                    int secondsPerGame = (minutes * 60) + seconds;
                    allSeconds += secondsPerGame;
                    games++;
                }
            }
            double average = (double)allSeconds / games;
            
            if (average < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if ((average >= 720) && (average <= 1440))
            {
                Console.WriteLine("Silver Star");
            }
            else if (average > 1440)
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", games, Math.Ceiling(average));

        }
    }
}
