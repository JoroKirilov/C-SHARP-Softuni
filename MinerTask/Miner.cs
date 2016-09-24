using System;
using System.Collections.Generic;


    class Miner
    {
        static void Main()
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            string kindOfMetal = Console.ReadLine();
            while (kindOfMetal != "stop")
            {
                int quantityOfMetal = int.Parse(Console.ReadLine());
                myDict[kindOfMetal] = quantityOfMetal;
                kindOfMetal = Console.ReadLine();
            }
            foreach (var kvp in myDict)
            {
                Console.WriteLine("{0} -> {1}" , kvp.Key , kvp.Value);
            }
            
        }
    }

