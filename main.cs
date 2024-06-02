using System;

class Program {
 public static void Main (string[] args) {
   const double Centimeters = 2.54;
   Console.WriteLine("Please enter measurements in inches: ");
   var input = Console.ReadLine();
   
   if (double.TryParse(input, out double inches)){
     double centimeters = inches * Centimeters;
     Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);  
   }
   else {
     Console.WriteLine("Invalid input");
   }

 }    

}