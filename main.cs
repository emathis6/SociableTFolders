using System;

class Program {
 public static void Main (string[] args) {
   const double Centimeters = 2.54;
   int inches = 3;
   int test1 = 5;
   int test2 = 50;
   int test3 = -15;
   int test4 = 15994;
   double centimeters = inches * Centimeters;
   double centimeters1 = test1 * Centimeters;
   double centimeters2 = test2 * Centimeters;
   double centimeters3 = test3 * Centimeters;
   double centimeters4 = test4 * Centimeters;
   Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters); 
   Console.WriteLine("{0} inches is {1} centimeters", test1, centimeters1); 
   Console.WriteLine("{0} inches is {1} centimeters", test2, centimeters2); 
   Console.WriteLine("{0} inches is {1} centimeters", test3, centimeters3); 
   Console.WriteLine("{0} inches is {1} centimeters", test4, centimeters4); 
  }
}  