using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountyPopulation
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> myDict = new Dictionary<string, Dictionary<string, long>>();
        while (input != "report")
        {
            string[] splitInput = input.Split('|');
            string country = splitInput[1];
            string city = splitInput[0];
            long numbers = long.Parse(splitInput[2]);
            if (!myDict.ContainsKey(country))
            {
                myDict.Add(country, new Dictionary<string, long>());
                myDict[country].Add("total", 0);
            }
            if (!myDict[country].ContainsKey(city)) ;
            {
                myDict[country].Add(city, numbers);
                myDict[country]["total"] += numbers;
            }


            input = Console.ReadLine();
        }
        //sort
        List<KeyValuePair<string, long>> sortedList = new List<KeyValuePair<string, long>>();
        foreach (KeyValuePair<string, Dictionary<string, long>> outerPair in myDict)
        {
            sortedList.Add(new KeyValuePair<string, long>(outerPair.Key, myDict[outerPair.Key]["total"]));
        }

        SortKeyValiePairs(sortedList);

        foreach (KeyValuePair<string , long> outerPair in sortedList)
        {
            Console.WriteLine("{0} (total population: {1})" , outerPair.Key , outerPair.Value);

            List<KeyValuePair<string, long>> sortedCityPopulation = new List<KeyValuePair<string, long>>();
            foreach (KeyValuePair<string , long> innerPair in myDict[outerPair.Key])
            {
                sortedCityPopulation.Add(new KeyValuePair<string, long>(innerPair.Key, innerPair.Value)); 
            }
            SortKeyValiePairs(sortedCityPopulation);

            foreach (KeyValuePair<string , long> cityPrint in sortedCityPopulation)
            {
                if (cityPrint.Key != "total")
                {
                    Console.WriteLine("=>{0}: {1}", cityPrint.Key, cityPrint.Value);
                }
                
            }

            

        }

        //print

    }

    private static void SortKeyValiePairs(List<KeyValuePair<string, long>> sortedList)
    {
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                if (sortedList[i].Value < sortedList[i + 1].Value)
                {
                    Swap(sortedList, i, i + 1);
                    isSorted = false;
                }
            }
        }
    }

    private static void Swap(List<KeyValuePair<string, long>> sortedList, int i, int p)
    {
        KeyValuePair<string, long> temp = sortedList[i];
        sortedList[i] = sortedList[p];
        sortedList[p] = temp;

    }
}


            

    


