using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDiet
{
    class FitnesDiet
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string g = Console.ReadLine();
            int e = int.Parse(Console.ReadLine());
            double wInKg = w / 2.2;
            double hInSm = h * 2.54;
            double bmr = 0.0;
            double dci = 0.0;
            if (g == "m")
            {
                bmr = 66.5 + (13.75 * wInKg) + (5.003 * hInSm) - (6.755 * (double)age);
                //BMR = 66.5 + (13.75 x weight in kg) + (5.003 x height in cm) – (6.755 x age in years)
            }
            else if (g == "f")
            {
                bmr = 655 + (9.563 * wInKg) + (1.850 * hInSm) - (4.676 * (double)age);
                //BMR = 655 + (9.563 x weight in kg) + (1.850 x height in cm) – (4.676 x age in years)
            }
            if (e == 0)
            {
                dci = bmr * 1.2;
            }
            else if (e > 0 & e <= 3)
            {
                dci = bmr * 1.375;
            }
            else if (e > 3 & e <= 6 )
	        {
                dci = bmr * 1.55;
	        }
            else if (e > 6 & e <= 9)
            {
                dci = bmr * 1.725;
            }
            else if (e > 9)
            {
                dci = bmr * 1.9;
            }
            
            Console.WriteLine(Math.Floor (dci));
        }
    }
}
