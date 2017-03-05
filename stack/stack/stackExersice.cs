using System;
using System.Collections.Generic;
using System.Linq;



    class stackExersice
    {
        static void Main()
        {
            var numbers = Console.ReadLine().
                Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int
                .Parse);
                
                


            Stack<int> stack = new Stack<int>();

            foreach (var num in numbers)
            {
                stack.Push(num);
            }

            while (stack.Count != 0)
            {
                Console.Write("{0} " ,stack.Pop());
            }
        }
    }

