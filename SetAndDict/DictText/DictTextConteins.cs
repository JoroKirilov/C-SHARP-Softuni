using System;
using System.Collections.Generic;
using System.Linq;



class DictTextConteins
{
    static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<char, int> myDict = new SortedDictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            char currentSymbol = input[i];

            if (!myDict.ContainsKey(currentSymbol))
            {
                myDict[currentSymbol] = 0;
            }
            myDict[currentSymbol]++;

        }
        foreach (var item in myDict)
        {
            Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
        }
    }
}

