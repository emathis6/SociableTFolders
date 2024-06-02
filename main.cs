using System;

class Program {
 public static void Main (string[] args) {
   
   const double baseRate = 200.00;
   const double hourlyRate = 150.00;
   const double milesRate = 2.00;
   
   Console.WriteLine("Enter the number of hours: ");
   String hoursInput = Console.ReadLine();
   
   Console.WriteLine("Enter the number of miles: ");
   String milesInput = Console.ReadLine();

   double estimate = baseRate + (hourlyRate * double.Parse(hoursInput) + milesRate * double.Parse(milesInput));

   Console.WriteLine("Total estimate is: ${0:F2}", estimate);

   }

 }    


  
   
    
        
 