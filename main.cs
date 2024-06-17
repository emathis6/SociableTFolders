using System;
using System.Collections.Generic;
  class Program {
    static void Main (string[] args) {
      
      Console.WriteLine ("Please enter the salesperson's initial (D, E, or F):");
      string input = Console.ReadLine();
      Console.WriteLine("Please enter the amount of sales:");
      double input = Convert.ToDouble(Console.ReadLine());
      
      int sales = int.Parse(Console.ReadLine());
      int totalSalesD = 0;
      int totalSalesE = 0;
      int totalSalesF = 0;
      int grandTotal = 0;
      
      while true
      {
        Console.WriteLine ("Please enter the salesperson's initial (D, E, or F):");
        string salesPerson = Console.ReadLine();

        if (salesPerson != "D" && input != "E" && input != "F")
        {
          Console.WriteLine("Invalid input. Please enter D, E, or F.");
          continue;
          
       }
        Console.WriteLine("Please enter the amount of sales:");
        int sales = int.Parse(Console.ReadLine());
        }
            

        switch (salesPerson)
        {
          case 'D':
            totalSalesD += sale;
            break;
          case 'E':
            totalSalesE += sale;
            break; 
          case 'F':
            totalSalesF += sale;
            break;

          }
        }

      //Console.WriteLine ("D Total:{0}", dTotal);
      //Console.WriteLine ("E Total:{0}", eTotal);
      //Console.WriteLine ("F Total:{0}", fTotal);
      //Console.WriteLine ("Grand Total:{0}", dTotal + eTotal + fTotal);
     
      }
    } 



    

  
   
    
        
 