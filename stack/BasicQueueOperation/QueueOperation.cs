using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class QueueOperation
    {
        static void Main()
        {
            string [] datas = Console.ReadLine().Trim().Split(' ');
            int adds = int.Parse(datas[0]);
            int pops = int.Parse(datas[1]);
            int hasNum = int.Parse(datas[2]);
            Queue<int> numbers = new Queue<int>();
            string[] myNumbers = Console.ReadLine().Trim().Split(' ') ;

            
 
            for (int i = 0; i < adds; i++)
            {
                numbers.Enqueue(int.Parse(myNumbers[i]));
            }
            for (int i = 0; i < pops; i++)
            {
                numbers.Dequeue();
            }
            bool hasThatNum = numbers.Contains(hasNum);
            if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }

            else if (hasThatNum)
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = int.MaxValue;
                foreach (var item in numbers)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                Console.WriteLine(min);
                
            }
        }
    }

