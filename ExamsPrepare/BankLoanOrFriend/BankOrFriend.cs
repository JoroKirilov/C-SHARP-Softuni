using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoanOrFriend
{
    class BankOrFriend
    {
        static void Main()
        {
            double p = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double i = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            double fV = 0.0;
            double bankInterest = Math.Pow((1+i) ,n);
            fV = p * bankInterest;
            double friendFValue = p + (p * f);
            if (friendFValue <= fV)
            {
                Console.WriteLine("{0:F2} Friend" , friendFValue);
            }
            else if (friendFValue > fV)
            {
                Console.WriteLine("{0:F2} Bank" , fV );
            }
        }
    }
}
