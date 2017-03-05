using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class LogsAggregator
{
    static void Main()
    {
        SortedDictionary<string, SortedDictionary<string, long>> dict = new SortedDictionary<string, SortedDictionary<string, long>>();
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputNumber; i++)
        {
            string input = Console.ReadLine();
            string[] splitString = input.Split(' ');
            string user = splitString[1];
            string ipAdress = splitString[0];
            long counterAdress = long.Parse(splitString[2]);
            if (!dict.ContainsKey(user))
            {
                dict.Add(user, new SortedDictionary<string, long>());
            }
            if (!dict[user].ContainsKey(ipAdress))
            {
                dict[user].Add(ipAdress, 0);
            }
            dict[user][ipAdress] += counterAdress;
        }
        foreach (var outerPair in dict)
        {
            var sum = outerPair.Value.Values.Sum();
            Console.Write("{0}: {1} " ,outerPair.Key , sum);
            Console.Write("[");
            Console.Write(string.Join(", " , outerPair.Value.Keys));
            Console.Write("]");
            Console.WriteLine();

        }
        
    }
}



  

