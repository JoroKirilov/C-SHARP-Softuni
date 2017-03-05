using System;
using System.Collections.Generic;
using System.Linq;


namespace TheBetterMusicProducer
{
    class TheBetterMusicProducer
    {
        static void Main()
        {
            int albumsInEurope = int.Parse(Console.ReadLine());
            double priceInEurope = double.Parse(Console.ReadLine());
            int albumsInNAmerica = int.Parse(Console.ReadLine());
            double priceInNAmerica = double.Parse(Console.ReadLine());
            int albumsSAmerica = int.Parse(Console.ReadLine());
            double priceInSAmerica = double.Parse(Console.ReadLine());
            int numOfConcert = int.Parse(Console.ReadLine());
            double priceOfConcert = double.Parse(Console.ReadLine());

            double profitInEurope = albumsInEurope * (priceInEurope * 1.94);
            double profitInNAmerica = albumsInNAmerica * (priceInNAmerica * 1.72);
            double profitInSAmerica = albumsSAmerica * (priceInSAmerica / 332.74);
            double allProfitAlbums = (profitInEurope + profitInNAmerica + profitInSAmerica);
            double profitalbums = allProfitAlbums - (allProfitAlbums * 0.35);
            double taxesAlbums = profitalbums - (profitalbums * 0.20);
            double profitFromAllConcert = numOfConcert * (priceOfConcert * 1.94);

            if (profitFromAllConcert > 100000 & profitFromAllConcert > taxesAlbums)
            {
                profitFromAllConcert -= (profitFromAllConcert * 0.15);
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", profitFromAllConcert);
            }
            else if (profitFromAllConcert < 100000 & profitFromAllConcert > taxesAlbums)
	{
        Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", profitFromAllConcert);	 
	}
            
            if (taxesAlbums > profitFromAllConcert)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", taxesAlbums);
            }
        
        }
    }
}
