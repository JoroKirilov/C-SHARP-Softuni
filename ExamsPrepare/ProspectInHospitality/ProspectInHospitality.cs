using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main()
        {
            int b = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double u = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double salaryForB = (double)b * 1500.04;
            double salaryForR = (double)r * 2102.10;
            double salaryForC = (double)c * 1465.46;
            double salaryForT = (double)t * 2053.33;
            double salaryForO = (double)o * 3010.98;
            double nikiSalary = (double)u * n;
            double allMoneyForMounth = salaryForB + salaryForC + salaryForO + salaryForR + salaryForT + nikiSalary + s;
            Console.WriteLine("The amount is: {0:F2} lv." , allMoneyForMounth);
            if (allMoneyForMounth > m)
            {
                double noMoney = allMoneyForMounth - m;
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", noMoney);
            }
            else
            {
                double leftMoney = m - allMoneyForMounth;
                Console.WriteLine("YES \\ Left: {0:F2} lv.", leftMoney);
            }
        }

     }
}
