using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string enteredData = Console.ReadLine();
        string[] splitEnterdData = enteredData.Split('-');
        string name = splitEnterdData[0];
        string phone = splitEnterdData[1];
        while (enteredData != "search")
        {
            phonebook[name] = phone;
            enteredData = Console.ReadLine();
        }
        enteredData = Console.ReadLine();
        while (enteredData != "stop")
        {
            if (phonebook.ContainsKey(enteredData))
            {
                Console.WriteLine("{0} -> {1}" , enteredData , phonebook[enteredData]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", enteredData);
            }
            enteredData = Console.ReadLine();
        }



    }
}