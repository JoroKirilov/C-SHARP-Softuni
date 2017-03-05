using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CalcQueue
    {
        static void Main(string[] args)
        {
            string stringNum = Console.ReadLine();

            long number = long.Parse(stringNum);

            Queue<long> operation = new Queue<long>();
            operation.Enqueue(number);
            List<long> result = new List<long>();
            result.Add(number);

            while (result.Count < 50)
            {
                long currentElement = operation.Dequeue();
                long numOne = currentElement + 1;
                long numTwo = currentElement * 2 + 1;
                long numThree = currentElement + 2;

                operation.Enqueue(numOne);
                operation.Enqueue(numTwo);
                operation.Enqueue(numThree);

                result.Add(numOne);
                result.Add(numTwo);
                result.Add(numThree);

            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }



        }
    }

