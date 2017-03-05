using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MasterHerbalist
{
    class MasterHerbalist
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string resultString = "";
            int herb = 0;
            int sumTotalMoney = 0;
            int totalMoney = 0;
            int count = 0;
            decimal averagePerDay = 0.0m;
            decimal extraMoney = 0.0m;
            decimal moneyNeed = 0.0m;
            while (true)
            {

                string dayData = Console.ReadLine();
                if (dayData == "Season Over")
                {
                    break;
                }
                else
                {
                    herb = 0;
                    string[] splitString = dayData.Split(' ');
                    int hoursPerDay = int.Parse(splitString[0]);
                    int moneyForHerbs = int.Parse(splitString[2]);
                    string text = splitString[1];
                    if (text.Length < hoursPerDay)
                    {
                        for (int i = 0; i < hoursPerDay - text.Length + 1; i++)
                        {
                            resultString = "";
                            resultString += string.Concat(text + text);
                        }
                        for (int i = 0; i < hoursPerDay; i++)
                        {
                            if (resultString[i] == 'H')
                            {
                                herb += 1;
                            }
                        }
                        totalMoney = herb * moneyForHerbs;
                    }
                    else
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (text[i] == 'H')
                            {
                                herb += 1;
                            }

                        }
                        totalMoney = herb * moneyForHerbs;
                    }
                    sumTotalMoney += totalMoney;
                    count++;
                }
            }
            averagePerDay = sumTotalMoney / (decimal)count;
            if (n < averagePerDay)
            {
               extraMoney = averagePerDay - n;
               Console.WriteLine("Times are good. Extra money per day: {0:F2}." , extraMoney);
            }
            else
            {
                moneyNeed = (n * count) - sumTotalMoney;
                Console.WriteLine("We are in the red. Money needed: {0}." , moneyNeed);
            }
            
        }
    }
}
