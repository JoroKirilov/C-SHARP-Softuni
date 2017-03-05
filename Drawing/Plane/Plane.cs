using System;


class Plane
{
   static void Main()
   {
       string pOne = Console.ReadLine();
       int n = int.Parse(Console.ReadLine());
       string pTwo ="";
       int resultPOne = 0;
       int resultPTwo = 0;
       if (pOne == "Simeon" )
       {
           pTwo = "Nakov";
       }
       else if (pOne == "Nakov")
       {
           pTwo = "Simeon";
       }
       for (int i = 3; i <= n + 2 ; i++)
       {
           if (i % 2 == 1)
           {


               int pToStrikePOne = int.Parse(Console.ReadLine());
               string IsScore = Console.ReadLine();
               if (IsScore == "success" && resultPOne + pToStrikePOne <= 500)
               {
                   resultPOne += pToStrikePOne;
               }
               int pToStrikePTwo = int.Parse(Console.ReadLine());
               string IsScore1 = Console.ReadLine();
               if (IsScore1 == "success" && pToStrikePTwo + resultPTwo <= 500)
               {
                   resultPTwo += pToStrikePTwo;
               }
           }
           else if ( i % 2 == 0)
           {
               int pToStrikePTwo = int.Parse(Console.ReadLine());
               string IsScore1 = Console.ReadLine();
               if (IsScore1 == "success" && pToStrikePTwo + resultPTwo <= 500)
               {
                   resultPTwo += pToStrikePTwo;
               }
               int pToStrikePOne = int.Parse(Console.ReadLine());
               string IsScore = Console.ReadLine();
               if (IsScore == "success" && resultPOne + pToStrikePOne <= 500)
               {
                   resultPOne += pToStrikePOne;
               }

           }
           if (resultPOne == 500 || resultPTwo == 500)
          {
               if (resultPOne == 500 && resultPTwo == 500)
               {
                   Console.WriteLine("DRAW");
                   Console.WriteLine(resultPOne);
                   
               }
               else if (resultPOne == 500 && resultPTwo != 500)
               {
                   Console.WriteLine(pOne);
                   Console.WriteLine(i - 2);
                   Console.WriteLine(resultPTwo);
                   
               }
               else if (resultPTwo == 500 && resultPOne != 500)
               {
                   Console.WriteLine(pTwo);
                   Console.WriteLine(i - 2);
                   Console.WriteLine(resultPOne);
               }
           }
               
               if (i == n + 2 && resultPOne != 500 && resultPTwo != 500)
               {
                   if (resultPTwo == resultPOne)
                   {
                       Console.WriteLine("DRAW");
                       Console.WriteLine(resultPOne);
                   }
                   else if (resultPOne > resultPTwo)
                   {
                       Console.WriteLine(pOne);
                       Console.WriteLine(resultPOne - resultPTwo);
                   }
                   else if (resultPTwo > resultPOne)

	                {
		                Console.WriteLine(pTwo);
                        Console.WriteLine(resultPTwo - resultPOne);
	                }
                   break;
               }
               
           }
          
     
           
       }
   }


