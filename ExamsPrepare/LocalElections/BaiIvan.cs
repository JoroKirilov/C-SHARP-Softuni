using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class BaiIvan
    {
        static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            decimal alcohol = decimal.Parse(Console.ReadLine());
            decimal priceOfAlcohol = 0.0m;
            if (dayOfWeek == 0)
	{
		priceOfAlcohol = money / 25m;
	}
            else if (dayOfWeek == 1)
	{
		 priceOfAlcohol = money / 21m;
	}
            else if (dayOfWeek == 2)
	{
		 priceOfAlcohol = money / 14m;
	}
            else if (dayOfWeek == 3)
	{
		 priceOfAlcohol = money / 17m;
	}
            else if (dayOfWeek == 4)
	{
		 priceOfAlcohol = money / 45m;
	}
            else if (dayOfWeek == 5)
	{
		 priceOfAlcohol = money / 59m;
	}
            else if (dayOfWeek == 6)
	{
		 priceOfAlcohol = money / 42;
	}
            string status = string.Empty;
            if (priceOfAlcohol < 1.0m)
	{
       status = "sober";
	}
            else if (priceOfAlcohol >= 1.5m)
	{
        status = "very drunk";    
	}
            else if (priceOfAlcohol >= 1.0m && priceOfAlcohol < 1.5m)
	{
        status = "drunk";
	}
            if (priceOfAlcohol > alcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", status , 
                    priceOfAlcohol - alcohol);
            }
            else if (priceOfAlcohol < alcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", status , 
                    alcohol - priceOfAlcohol);
            }
            else if (alcohol == priceOfAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", status);
            }
         
            

        }
    }
}

