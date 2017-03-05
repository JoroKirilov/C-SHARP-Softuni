using System;
using System.Collections.Generic;


class Email
{
    static void Main()
    {
        Dictionary<string, string> emailAdresses = new Dictionary<string, string>();
        string nameOfPerson = Console.ReadLine();

        while (nameOfPerson != "stop")
        {
            string emailAdress = Console.ReadLine();
            string[] splitStringEmail = emailAdress.Split('.');
            string exstension = splitStringEmail[1];
            if (exstension != "us" || exstension != "uk") 
            {
                emailAdresses[nameOfPerson] = emailAdress;
            }
        
            nameOfPerson = Console.ReadLine();

        }
        foreach (var item in emailAdresses)
        {
            Console.WriteLine("{0} -> {1}" , item.Key , item.Value );
        }
    }
}
