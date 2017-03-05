using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkAni
{
    class Football
    {
        static void Main()
        {
            #region input
            int arsenalPoints = 0;
            int chelseaPoints = 0;
            int manchesterCityPoints = 0;
            int manchesterUntPoints = 0;
            int liverpoolPoints = 0;
            int evertonPoints = 0;
            int southamptomPoints = 0;
            int tottenhamPoints = 0;

            int numOfMatch = 0;
            int winPoints = 3;
            int drawPoints = 1;
           
            decimal paymentPerMatch = decimal.Parse(Console.ReadLine());
            string match = Console.ReadLine();
            #endregion
            while (match != "End of the league.")
            {
                char[] separator = new char[] { ' ' };
                string[] subString = match.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string team1 = subString[0];
                string team2 = subString[2];
                string sing = subString[1];
                #region  if sing is 1              
                if (sing == "1")
                {
                    switch (team1)
                    {
                        case "Arsenal": arsenalPoints += winPoints; break;
                        case "Chelsea": chelseaPoints += winPoints; break;
                        case "ManchesterCity": manchesterCityPoints += winPoints; break;
                        case "ManchesterUnited": manchesterUntPoints += winPoints; break;
                        case "Liverpool": liverpoolPoints += winPoints; break;
                        case "Everton": evertonPoints += winPoints; break;
                        case "Southampton": southamptomPoints += winPoints; break;
                        case "Tottenham": tottenhamPoints += winPoints; break;
                        default:
                            break;
                    }
                }
                #endregion

                #region if sing is 2                
                if (sing == "2")
                {
                    switch (team2)
                    {
                        case "Arsenal": arsenalPoints += winPoints; break;
                        case "Chelsea": chelseaPoints += winPoints; break;
                        case "ManchesterCity": manchesterCityPoints += winPoints; break;
                        case "ManchesterUnited": manchesterUntPoints += winPoints; break;
                        case "Liverpool": liverpoolPoints += winPoints; break;
                        case "Everton": evertonPoints += winPoints; break;
                        case "Southampton": southamptomPoints += winPoints; break;
                        case "Tottenham": tottenhamPoints += winPoints; break;
                        default:
                            break;
                    }
                }
                #endregion
                
                #region  if sing is X       
                if (sing == "X")
                {
                    switch (team1)
                    {
                        case "Arsenal": arsenalPoints += drawPoints; break;
                        case "Chelsea": chelseaPoints += drawPoints; break;
                        case "ManchesterCity": manchesterCityPoints += drawPoints; break;
                        case "ManchesterUnited": manchesterUntPoints += drawPoints; break;
                        case "Liverpool": liverpoolPoints += drawPoints; break;
                        case "Everton": evertonPoints += drawPoints; break;
                        case "Southampton": southamptomPoints += drawPoints; break;
                        case "Tottenham": tottenhamPoints += drawPoints; break;
                        default:
                            break;
                    }
                    switch (team2)
                    {
                        case "Arsenal": arsenalPoints += drawPoints; break;
                        case "Chelsea": chelseaPoints += drawPoints; break;
                        case "ManchesterCity": manchesterCityPoints += drawPoints; break;
                        case "ManchesterUnited": manchesterUntPoints += drawPoints; break;
                        case "Liverpool": liverpoolPoints += drawPoints; break;
                        case "Everton": evertonPoints += drawPoints; break;
                        case "Southampton": southamptomPoints += drawPoints; break;
                        case "Tottenham": tottenhamPoints += drawPoints; break;
                        default:
                            break;
                    }
                }
                #endregion

                match = Console.ReadLine();
                numOfMatch++;
            }
            #region  output
            decimal moneyForMatches = (paymentPerMatch * numOfMatch) * 1.94m;
            Console.WriteLine("{0:F2}lv." , moneyForMatches);
            Console.WriteLine("Arsenal - {0} points." , arsenalPoints );
            Console.WriteLine("Chelsea - {0} points." , chelseaPoints);
            Console.WriteLine("Everton - {0} points." , evertonPoints);
            Console.WriteLine( "Liverpool - {0} points." , liverpoolPoints);
            Console.WriteLine("Manchester City - {0} points." , manchesterCityPoints);
            Console.WriteLine("Manchester United - {0} points." , manchesterUntPoints);     
            Console.WriteLine("Southampton - {0} points" , southamptomPoints);
            Console.WriteLine("Tottehham - {0} points." , tottenhamPoints );
            #endregion

        }
    }
}
