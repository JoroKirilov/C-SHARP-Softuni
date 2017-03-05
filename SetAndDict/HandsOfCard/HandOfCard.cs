using System;
using System.Collections.Generic;

class HandOfCard
{
    static void Main()
    {
        string EnteredData = Console.ReadLine();
        Dictionary<string, Dictionary<int, HashSet<int>>> dict = new Dictionary<string, Dictionary<int, HashSet<int>>>();

        while (EnteredData != "Joker")
        {
            string[] splitString = EnteredData.Split(new char
                [] { ':', ',' });
            string name = splitString[0];
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, new Dictionary<int, HashSet<int>>());
            }
            for (int i = 1; i < splitString.Length; i++)
            {
                string currentCard = splitString[i];
                int face = 0;
                int power = 0;
                if (currentCard.Length > 2)
                {
                    face = int.Parse(currentCard.Substring(0, 2));
                    power = int.Parse(currentCard.Substring(2, 3));
                }
                else
                {
                    face = int.Parse(currentCard.Substring(0, 1));
                    power = int.Parse(currentCard.Substring(1, 2));
                }



                if (face == 'J')
                {
                    face = 11;
                }
                else if (face == 'Q')
                {
                    face = 12;
                }
                else if (face == 'K')
                {
                    face = 13;
                }
                else if (face == 'A')
                {
                    face = 14;
                }
                dict[name].Add(face, new HashSet<int>());

                if (power == 'S')
                {
                    power = 4;
                }
                else if (power == 'H')
                {
                    power = 3;
                }
                else if (power == 'D')
                {
                    power = 2;
                }
                else if (power == 'C')
                {
                    power = 1;
                }
                dict[name][face].Add(power);

            }
            EnteredData = Console.ReadLine();
        }
        foreach (var outerPair in dict)
        {
            Console.Write("{0} :", outerPair.Key);
            foreach (var item in outerPair.Value)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
           

   
      

 
