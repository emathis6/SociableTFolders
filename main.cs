using System;
class Program {
    static void Main (string[] args) { 
        decimal[] totalSales = new decimal[3];
        decimal grandTotal = 0;
      
      while (true)
      {
        Console.WriteLine ("Please enter the salesperson's initial:");
        string initialInput = Console.ReadLine().ToUpper();

        if (initialInput == "Z")
        {
          break;
          }
        int index = -1;
        switch (initialInput)
        {
          case "D" : index = 0; break;
          case "E" : index = 1; break;
          case "F" : index = 2; break;
          default : Console.WriteLine("Invalid initial");
          continue;    
        }
        Console.WriteLine("Please enter the salesperson's sales:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal saleAmount))
        {
          Console.WriteLine("Invalid sale amount");
          continue;
        }
        totalSales[index] += saleAmount;
        grandTotal += saleAmount;
        }
       string[] salespersonNames = {"D", "E", "F"};
       string highestSalesperson = "";
       decimal highestTotal = 0;
      for (int i = 0; i < totalSales.Length; i++)
      {
        if (totalSales[i] > highestTotal)
        {
          highestTotal = totalSales[i];
          highestSalesperson = salespersonNames[i];  
        }
      }
      Console.WriteLine ($"\nGrand Total: {grandTotal:C}");
      Console.WriteLine ($"Highest Sale: {highestSalesperson}");
      }
    } 



    

  
   
    
        
 