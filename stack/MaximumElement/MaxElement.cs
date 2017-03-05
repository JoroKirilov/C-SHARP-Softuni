using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxElement
{
    static void Main()
    {
        string numOfEntries = Console.ReadLine();
        Stack<int> numbers = new Stack<int>();

        for (int i = 0; i < int.Parse(numOfEntries); i++)
        {
            string [] element = Console.ReadLine().Split(' ');
            int numOne = int.Parse(element[0]);
            
            
                            if (numOne == 1)
                {
                    int numTwo = int.Parse(element[1]);
                    numbers.Push(numTwo);
                }
                            else if (numOne == 2)
                            {
                                numbers.Pop();
                            }
                            else
                            {
                                int max = int.MinValue;
                                foreach (var num in numbers)
                                {
                                    if (num > max)
                                    {
                                        max = num;
                                    }
                                }
                                Console.WriteLine(max);
                            }      
        }
    }
}
