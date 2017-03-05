using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentPirate
{
    class TorrentPirate
    {
        static void Main()
        {
            decimal d = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal w = decimal.Parse(Console.ReadLine());
            decimal movieSize = 1500m;
            decimal fixedSpeed = 2m;

            decimal downloadTime = d / fixedSpeed / 60 / 60;
            decimal priceForDownload = downloadTime * w;
            decimal cinemaPrise = p * (d / movieSize);
            if (cinemaPrise >= priceForDownload)
            {
                Console.WriteLine("mall -> {0:F2}lv", priceForDownload);

            }
            else
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaPrise);
            }

        }
    }
}