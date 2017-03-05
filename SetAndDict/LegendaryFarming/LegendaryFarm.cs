using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LegendaryFarm
{
    static void Main()
    {
        SortedDictionary<string, long> dict = new SortedDictionary<string, long>();
        string input = Console.ReadLine();
        input = input.ToLower();
        string[] splitString = input.Split();
        for (int i = 1; i <= splitString.Count(); (i + 2);)
        {
                dict.Add(splitString[i], new long());
            
            
        }
        foreach (var kvp in dict)
        {
            Console.WriteLine("{0}{1}", kvp.Key , kvp.Value);
        }


    }
}

