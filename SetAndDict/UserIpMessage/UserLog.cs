using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UserLog
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        SortedDictionary<string , Dictionary<string , int>> dict = new SortedDictionary<string,Dictionary<string,int>>();
        int count = 0;
        while (input != "end")
        {
            string[] splitStringByEqual = input.Split(new char[] { '=', ' ' });
            string ipAdress = splitStringByEqual[1];
            string user = splitStringByEqual[5];
            if (!dict.ContainsKey(user))
            {
                dict.Add(user , new Dictionary<string , int>());
                dict[user].Add(ipAdress, 0);
            }
            else if (!dict[user].ContainsKey(ipAdress))
            {
                dict[user].Add(ipAdress, 0);
            }
            
            input = Console.ReadLine();
        }
        foreach (var outerPair in dict)
        {
            Console.WriteLine("{0}: " , outerPair.Key);
            Console.WriteLine("{0}.", 
                string.Join(", " , outerPair
                .Value
                .Select(kv => kv.Key + " => " + kv.Value)));
        }
        

    }
}

