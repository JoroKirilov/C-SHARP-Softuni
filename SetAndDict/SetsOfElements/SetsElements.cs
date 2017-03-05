using System;
using System.Collections.Generic;




    class SetsElements
    {
        static void Main()
        {
            string sets = Console.ReadLine();
            string[] splitSets = sets.Split(' ');
            int firstNumbs = int.Parse(splitSets[0]);
            int secondNumbs = int.Parse(splitSets[1]);
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < firstNumbs; i++)
            {
                int setOne = int.Parse(Console.ReadLine());
                firstSet.Add(setOne);

            }
            for (int i = 0; i < secondNumbs; i++)
            {
                int setTwo = int.Parse(Console.ReadLine());
                secondSet.Add(setTwo);
            }
            firstSet.IntersectWith(secondSet);
            foreach (var item in firstSet)
            {
                Console.WriteLine(item);
            }


        }
    }

