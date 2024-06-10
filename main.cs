using System;
using System.Text.RegularExpressions;

class Program {
 static void Main (string[] args) {

    Console.WriteLine("Enter wind speed in miles per hour:");
    string input = Console.ReadLine();

    string numericPart = Regex.Replace(input, @"[^0-9.]", "");

    if (double.TryParse(numericPart, out double windSpeed))
         
    {
      if (windSpeed >= 157){
        Console.WriteLine("Category Five Hurricane");
       } 
       else if (windSpeed >= 130){
        Console.WriteLine("Category Four Hurricane");
       } 
       else if (windSpeed >= 111){
        Console.WriteLine("Category Three Hurricane");
       }
       else if (windSpeed >= 96){
        Console.WriteLine("Category Two Hurricane");
       }
       else if (windSpeed >= 74){
        Console.WriteLine("Category One Hurricane");
       }
       else   
       {
        Console.WriteLine("Not a Hurricane");
       }
    }
    else
    {
       Console.WriteLine("Invalid input. Please enter a valid number.");
    }
  }
}



    

  
   
    
        
 