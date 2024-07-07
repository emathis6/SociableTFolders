using System;

class Program
{
  public static void Main()
  {
    DisplayMessage();
    string input = Console.ReadLine();
    
    if (input == "1")

    {
      
      Console.WriteLine("How many contestants in previous year?");
      int contestantsLastYear = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many contestants in current year?");
      int contestantsThisYear = Convert.ToInt32(Console.ReadLine());

      {
       if (contestantsThisYear > 2 * contestantsLastYear)
      {
        Console.WriteLine("The competition is more than twice as big this year!");
      }
      else if (contestantsThisYear > contestantsLastYear)
      {
        Console.WriteLine("The competition is bigger than ever!");
      }
      else
      {
        Console.WriteLine("A tight race this year! Come out and cast your vote!");
      }
     }
    }
  }
      //else if (input == "2")
      //{
        //Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
      //}

      //Console.WriteLine("It is true that this year's competition is bigger than last year's.");
    

    static void DisplayMessage()
    {
      Console.WriteLine("************************************");
      Console.WriteLine("*  The stars shine in Greenville.  *");
      Console.WriteLine("************************************");
      Console.WriteLine();
      Console.WriteLine("Please Enter the following number below from the following menu:");
      Console.WriteLine();
      Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
      Console.WriteLine("2. Exit");
    }
    }
  
  





 