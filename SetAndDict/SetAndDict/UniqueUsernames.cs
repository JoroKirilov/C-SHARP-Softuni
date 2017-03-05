using System;
using System.Collections.Generic;


    class UniqueUsername
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            SortedSet<string> usernames = new SortedSet<string>();

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                usernames.Add(name); 
                
            }
           

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }

