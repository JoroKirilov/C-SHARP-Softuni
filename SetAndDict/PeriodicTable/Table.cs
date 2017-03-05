using System;
using System.Collections.Generic;


class Table
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        SortedSet<string> elements = new SortedSet<string>();
        for (int i = 0; i < number; i++)
        {

            string chemicalElement = Console.ReadLine();
            string[] splitChemicalElements = chemicalElement.Split(' ');
            for (int n = 0; n < splitChemicalElements.Length; n++)
            {
                elements.Add(splitChemicalElements[n]);
            }

        }
        foreach (var item in elements)
        {
            Console.Write("{0} ", item);
        }

    }
}

