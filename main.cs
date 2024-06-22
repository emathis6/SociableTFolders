using System;
class Program {
    static void Main (string[] args) { 
        decimal totalSalesD = 0;
        decimal totalSalesE = 0;
        decimal totalSalesF = 0;
        decimal grandTotal = 0;
      
      while (true)
      {
        Console.WriteLine ("Please enter the salesperson's initial:");
        string initialInput = Console.ReadLine().ToUpper();

        if (initialInput == "Z")
        {
          break;
          }
        
        if (initialInput != "D" && initialInput != "E" && initialInput != "F")
        {
          Console.WriteLine("Invalid input. Please enter a valid initial.");
          continue;

        }
        
        Console.WriteLine("Please enter the salesperson's sales:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal saleAmount))

        {
          Console.WriteLine("Invalid input. Please enter a valid sales amount.");
          
        }

        switch (initialInput)
        {
        case "D":
          totalSalesD += saleAmount;
          break;

        case "E":
          totalSalesE += saleAmount;
          break;

        case "F":
          totalSalesF += saleAmount;
          break;
        }
        grandTotal += saleAmount;
        }

        string highestSalesperson = "";
        decimal highestTotal = 0;
      
        if (totalSalesD > highestTotal)
        {
          highestTotal = totalSalesD;
          highestSalesperson = "D";
        }
        if (totalSalesE > highestTotal)
        {
          highestTotal = totalSalesE;
          highestSalesperson = "E";
        }
        if (totalSalesF > highestTotal)
        {
          highestTotal = totalSalesF;
          highestSalesperson = "F";
        }

      Console.WriteLine ($"\nGrand Total: {grandTotal:C}");
      Console.WriteLine ($"Highest Sale: {highestSalesperson}");
     
      }
    } 



    

  
   
    
        
 