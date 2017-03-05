using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BeersStock
{
    class BeersStock
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            string shipment = Console.ReadLine();
            decimal sumOfBeer = 0.0m;
            decimal breakBeers = 0.0m;
            decimal cases = 0.0m;
            decimal sixpacks = 0.0m;
            decimal beers = 0.0m;
            decimal leftBeer = 0.0m;
            while (shipment != "Exam Over")
            {
                string[] splitString = shipment.Split(' ');
                string typeOfBeers = splitString[1];
                int beer = int.Parse(splitString[0]);

                if (typeOfBeers == "cases")
                {
                    sumOfBeer += beer * 24;
                }
                else if (typeOfBeers == "sixpacks")
                {
                    sumOfBeer += beer * 6;
                }
                else
                {
                    sumOfBeer += beer;
                }


                shipment = Console.ReadLine();
            }

            if (sumOfBeer > 100)
            {
                sumOfBeer / 100;
            }

            if (sumOfBeer > n)
            {

                leftBeer = sumOfBeer - n;
                if (leftBeer >= 24)
                {
                    cases = leftBeer / 24m;
                    leftBeer = leftBeer % 24m;
                    if (leftBeer > 6)
                    {
                        sixpacks = leftBeer / 6m;
                        beers = leftBeer % 6m;
                    }
                    else
                    {
                        leftBeer = beers;
                    }
                }
                if (leftBeer >= 6 && leftBeer < 24)
                {
                    sixpacks = leftBeer / 6m;
                    beers = leftBeer % 6m;
                }
                if (leftBeer < 6)
                {
                    beers = leftBeer;
                }

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", Math.Floor(cases), Math.Floor(sixpacks), Math.Floor(beers));

            }
            if (sumOfBeer < n)
            {
                leftBeer = n - sumOfBeer;
                if (leftBeer >= 24)
                {
                    cases = leftBeer / 24m;
                    leftBeer = leftBeer % 24m;
                    if (leftBeer >= 6)
                    {
                        sixpacks = leftBeer / 6m;
                        beers = leftBeer % 6m;
                    }
                    else
                    {
                        leftBeer = beers;
                    }

                }
                if (leftBeer >= 6 && leftBeer < 24)
                {
                    sixpacks = leftBeer / 6m;
                    beers = leftBeer % 6m;
                }
                else
                {
                    beers = leftBeer;
                }
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", Math.Floor(cases), Math.Floor(sixpacks), Math.Floor(beers));
            }
        }
    }
}