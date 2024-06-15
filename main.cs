using System;
using System.Collections.Generic;

class Program {
 static void Main () {

   List<int> perfectNumbers = new List<int>();

    Console.WriteLine("Please enter a number between 1 and 10,000: ");
    for (int i = 1; i <= 10000; i++)
    {
      if (IsPerfectNumber(i))
      {
        perfectNumbers.Add(i);
      }
    }

    while (true) 
    {
      string input = Console.ReadLine();

      if (int.TryParse(input, out int number))
      {
        if (IsPerfectNumber(number))
        {
          Console.WriteLine("Perfect Number");
        }
        else
        {
          Console.WriteLine("Not a Perfect Number");
        }
      }
    }
 }
  

static bool IsPerfectNumber(int number)
{
  if (number < 2)
    return false; 

    int sum = 1;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
      if (number % i == 0)
      {
        sum += i;
        if (i != number / i)
        {
          sum += number / i;
        }
      }
    }
    return sum == number;
  }
  }




    

  
   
    
        
 