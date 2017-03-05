using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BasicOperations
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine().Trim();

            string [] numbs = numbers.Split(' ');

            int firstnum = int.Parse(numbs[0]);

            

            

            string myNumbers = Console.ReadLine();
            string [] elements = myNumbers.Trim().Split(' ');
            Stack<int> myElements = new Stack<int>();
            for (int i = 0; i < firstnum; i++)
            {
                
                myElements.Push(int.Parse(elements[i]));
            }


                for (int n = 0; n < int.Parse(numbs[1]); n++)
                {
                    myElements.Pop();
                }
                if (myElements.Count == 0) 
                {
                    Console.WriteLine("0");
                }
                else 
                {
                bool hasElement = myElements.Contains(int.Parse(numbs[2]));
                if (hasElement)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int min = int.MaxValue;
                    foreach (var element in myElements)
                    {
                        if (element < min)
                        {
                            min = element;
                        }
                        
                    }
                    Console.WriteLine(min);
                }

                    
                }
            }

        }
    
