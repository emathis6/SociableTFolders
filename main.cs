using System;

partial class Program
{
  static void Main()
  {
    int[] temperatures = new int[5];
    bool validTemps = false;

    while (!validTemps){
      Console.WriteLine("Temperature");

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"Temperature {i + 1}: ");
        int temp = int.Parse(Console.ReadLine());

        while (temp < -30 || temp > 130)
        {
          Console.WriteLine("Invalid temperature");
          temp = Int32.Parse(Console.ReadLine());
          }
        temperatures[i] = temp;
      }

      bool ascending = true;
      bool descending = true;

      for (int i = 0; i < 4; i++)
        
      {
        if (temperatures[i] > temperatures[i + 1])
        {
          ascending = false;
        }
        if (temperatures[i] < temperatures[i + 1])
        {
        descending = false;
        }
      }

      if (!ascending && !descending)
      {
        Console.WriteLine("It's a mixed bag");
        }
      else if (ascending)
        {
         Console.WriteLine("It's getting warmer");
         }
      else if (descending)
      {
        Console.WriteLine("It's getting colder");
      }
      else 
      {
        Console.WriteLine("It's a mixed bag");
      }
      validTemps = ascending || descending;
    }

      Console.WriteLine("5-day Temperature: [");
      for (int i = 0; i < 5; i++)  
      {
          Console.WriteLine(temperatures[i]);
          if (i < 4)
          {
            Console.Write(",");
          }
      }  
          
      Console.WriteLine("]");

      double average = CalculateAverage(temperatures);
      Console.Write($"Average Temperature is {average} degrees");

    } 

static double CalculateAverage(int[] temperatures)
  {
    int sum = 0;
    foreach (int temp in temperatures)
    {
      sum += temp;
    }
     return (double)sum / temperatures.Length;
    }
}
    
          
          
  



    

  
   
    
        
 