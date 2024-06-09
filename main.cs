using System;

class Program {
 static void Main (string[] args) {
   
    const int MaxLength = 140;
    Console.WriteLine("Enter your message:");
    string message = Console.ReadLine();
    if(message.Length > MaxLength)
    {
      Console.WriteLine("Rejected");

       }
    else
      Console.WriteLine("Posted");
    
   }

 }    


  
   
    
        
 