using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FormatNumbers
    {
        static void Main()
        {
            
            string input = Console.ReadLine().Trim();
            string [] splitInput = input.Split(' ' , '\n' , '\t' );
            int number = int.Parse(splitInput[0]);
            double numberTwo = double.Parse(splitInput[1]);
            double numberThreeq = double.Parse(splitInput[2]);
            string hexadecimalNumber = number.ToString("X");
            string result = "|" + hexadecimalNumber.PadRight(10 , ' ') + "|";
            Console.Write(result);
            string binaryNumb = Convert.ToString(number, 2).PadLeft(10 , '0');
            Console.Write(binaryNumb + "|");
            string numb = numberTwo.ToString("0.00").PadLeft(10, ' ');
            Console.Write(numb + '|');
            string numberThree = numberThreeq.ToString("0.000").PadRight(10 , ' ');
            Console.Write(numberThree + '|');
            Console.WriteLine();



        }
    }

