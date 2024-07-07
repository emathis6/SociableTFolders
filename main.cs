using System;
class Program
{
  static void Main(string[] args)
  {
    DisplayMessage();

    string input = Console.ReadLine();

    if (input == "1")
    {
      Console.WriteLine("How many contestants last year?");
      int contestantsLastYear = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many contestants this year?");
      int contestantsThisYear = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"Last year's competition had {contestantsLastYear} contestants, and this year's has {contestantsThisYear} contestants");

      int revenueExpectedThisYear = contestantsThisYear * 25;
      Console.WriteLine($"Revenue expected this year is ${revenueExpectedThisYear:N0}");
      Console.WriteLine("It is true that this year's competition is bigger than last year's.");
    }

    else if (input == "2")
    {
      Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
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





 