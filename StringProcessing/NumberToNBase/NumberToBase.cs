using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NumberToBase
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        BigInteger numberBase = BigInteger.Parse(input[0]);
        BigInteger number = BigInteger.Parse(input[1]);
        string result = "";

        do
        {
            result += number % numberBase;
            number /= numberBase;

        } while (number > 0);
        {



            char[] reversedNumber = result.ToCharArray();
            Array.Reverse(reversedNumber);
            string numberSearched = string.Join("", reversedNumber);
            Console.WriteLine(numberSearched);
        }
    }
}

