using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattleField
{
    class CheapestGame
    {
        static void Main()
        {
            decimal rubles = decimal.Parse(Console.ReadLine());
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal euros = decimal.Parse(Console.ReadLine());
            decimal bSait = decimal.Parse(Console.ReadLine());
            decimal mSait = decimal.Parse(Console.ReadLine());
            decimal rublesInLv = rubles / 3.5m;
            decimal dollarsInLv = dollars * 1.5m;
            decimal eurosInLv = euros * 1.95m;
            decimal bSaitPrice = bSait / 2m;
            if (rublesInLv < dollarsInLv && rublesInLv < eurosInLv && rublesInLv < bSaitPrice && rublesInLv < mSait)
            {
                Console.WriteLine("{0:F2}" , rublesInLv);
            }
            else if (dollarsInLv < rublesInLv && dollars < eurosInLv && dollarsInLv < bSaitPrice && dollarsInLv < mSait)
            {
                Console.WriteLine("{0:F2}" , dollarsInLv);
            }
            else if (eurosInLv < dollarsInLv && eurosInLv < rublesInLv && eurosInLv < bSaitPrice && eurosInLv < mSait)
            {
                Console.WriteLine("{0:F2}" , dollarsInLv);
            }
            else if (bSaitPrice < rublesInLv && bSaitPrice < dollarsInLv && bSaitPrice < eurosInLv && bSaitPrice < mSait)
            {
                Console.WriteLine("{0:F2}", bSaitPrice);
            }
            else if (mSait < rublesInLv && mSait < dollarsInLv && mSait < eurosInLv & mSait < bSaitPrice)
            {
                Console.WriteLine("{0:F2}", mSait);
            }
	    
        }
    }
}
