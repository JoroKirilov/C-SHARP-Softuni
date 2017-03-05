using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrifonDreamItem
{
    class TrifonDreamItem
    {
        static void Main()
        {
            string TrifonData = Console.ReadLine();
            string[] splitString = TrifonData.Split('\\');
            string month = (splitString[0]);
            decimal monthDays = 0.0m;
            decimal trifonBonus = 0;
            if (month == "Feb")
            {
                monthDays = 28 - 10;
            }
            else if (month == "Jan" || month == "March" || month == "May" || month == "July" || month == "Sept" || month == "Nov")
            {
                monthDays = 31 - 10;
            }
            else
            {
                monthDays = 30 - 10;
            }
            decimal moneyPerHour = decimal.Parse(splitString[1]);
            decimal hourPerDay = decimal.Parse(splitString[2]);
            decimal priceOfDream = decimal.Parse(splitString[3]);
            decimal trifonMoney = (moneyPerHour * hourPerDay) * monthDays;
            if (trifonMoney > 700)
            {
                trifonBonus = trifonMoney * 0.10m;
            }
            if ((trifonMoney + trifonBonus) > priceOfDream)
            {
                Console.WriteLine("Money left = {0:F2} leva.", (trifonMoney + trifonBonus) - priceOfDream);
            }
            else 
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", priceOfDream - (trifonMoney + trifonBonus));
            }

        }
    }
}
