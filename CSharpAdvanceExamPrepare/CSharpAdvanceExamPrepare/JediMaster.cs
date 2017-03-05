using System;
using System.Collections.Generic;

    class JediMaster
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool isYodaExist = false;
            Queue<string> master = new Queue<string>();
            Queue<string> knight = new Queue<string>();
            Queue<string> padawans = new Queue<string>();
            Queue<string> special = new Queue<string>();

            for (int i = 0; i < n; i++)
            
            {
                string input = Console.ReadLine();

                string [] splitInput = input.Split(' ');
                for (int j = 0; j < splitInput.Length; j++)

                {
                    string currentElement = splitInput[j].Substring(0 ,1);
                    switch (currentElement)
                    {
                        case "m":
                            master.Enqueue(splitInput[j]);
                            break;
                        case "k":
                            knight.Enqueue(splitInput[j]);
                            break;
                        case "p":
                            padawans.Enqueue(splitInput[j]);
                            break;
                        case "t":
                            special.Enqueue(splitInput[j]);
                            break;
                        case "s":
                            special.Enqueue(splitInput[j]);
                            break;
                        case "y":
                            isYodaExist = true;
                            break;
                    }
                }
                
            }
            if (isYodaExist)
            {
                Console.WriteLine(string.Join(" ", master));
                Console.WriteLine(string.Join(" ", master));
                Console.WriteLine(string.Join(" ", master));
                Console.WriteLine(string.Join(" ", master));
                Console.WriteLine(string.Join(" ", master));
            }
                
        }
    }

