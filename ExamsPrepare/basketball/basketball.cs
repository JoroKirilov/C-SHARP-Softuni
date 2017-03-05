using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basketball
{
    class basketball
    {
        static void Main()
        {
            decimal fG = decimal.Parse(Console.ReadLine());
            decimal fGA = decimal.Parse(Console.ReadLine()); 
            decimal threeP = decimal.Parse(Console.ReadLine());
            decimal tOV  = decimal.Parse(Console.ReadLine()); 
            decimal oRB = decimal.Parse(Console.ReadLine());
            decimal oPPDRB = decimal.Parse(Console.ReadLine());
            decimal fT = decimal.Parse(Console.ReadLine());
            decimal fTA = decimal.Parse(Console.ReadLine());
            decimal eFG = (fG + 0.5M * threeP) / fGA ;
            //(Field Goals (FG) + 0.5 * 3-Point Field Goals (3P)) / Field Goals Attempted (FGA). eFG%
            decimal tOVPercent = tOV / (fGA + 0.44M * fTA + tOV);
            //Turnovers (TOV) / (FGA + 0.44 * Free Throw Attempts (FTA) + TOV) TOV%
            decimal oRBPercent = oRB / (oRB + oPPDRB);
            //Offensive Rebounds (ORB) / (ORB + Opponent Defensive Rebounds (Opp DRB)). ORB%
            decimal fTPercent = fT / fGA;
            //Free Throws (FT) / FGA FT%
            Console.WriteLine("eFG% {0:F3}" , eFG);
            Console.WriteLine("TOV% {0:F3}" , tOVPercent);
            Console.WriteLine("ORB% {0:F3}" , oRBPercent);
            Console.WriteLine("FT% {0:F3}" , fTPercent);


        }
    }
}
