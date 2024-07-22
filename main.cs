using System;

class Program
{
  public static void Main()
  {
    DisplayMessage();
    string input = Console.ReadLine();
    
    if (input == "1")

    {
      
      int contestantsLastYear = GetValidContestantsNumber("How many contestants in previous year?");
      int contestantsThisYear = GetValidContestantsNumber("How many contestants in this year");
      

      {
       if (contestantsThisYear == 2 * contestantsLastYear)
      {
        Console.WriteLine("The competition is more than twice as big this year!");
      }
        else if (contestantsThisYear >= 2 * contestantsLastYear)
      {
        Console.WriteLine("The competition is bigger than ever!");
      }
      else
      {
        Console.WriteLine("A tight race this year! Come out and cast your vote!");
      }
     }
    }


    static int GetValidContestantsNumber(string prompt)
    {
      int number;
      bool isValidNumber = false;

      do
      {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();

        if (int.TryParse(input, out number) && number >= 0 && number <= 30)
        {
          isValidNumber = true;
          
        }
        else
        {
          Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
        }
      } while (!isValidNumber);
      
      return number;

  }    
      
    
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
  }

    
  
  





 