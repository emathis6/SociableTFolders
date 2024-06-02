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
  
     
   
   //Console.WriteLine("Please enter another number of inches: ");
   //var x = Console.ReadLine();


   //double centimeters1 = test1 * Centimeters;
   //double centimeters2 = test2 * Centimeters;
   //double centimeters3 = test3 * Centimeters;
   //double centimeters4 = test4 * Centimeters;

   //Console.WriteLine("{0} inches is {1} centimeters", test1, centimeters1);
   //Console.WriteLine("{0} inches is {1} centimeters", test2, centimeters2); 
   //Console.WriteLine("{0} inches is {1} centimeters", test3, centimeters3); 
   //Console.WriteLine("{0} inches is {1} centimeters", test4, centimeters4); 
  }
}