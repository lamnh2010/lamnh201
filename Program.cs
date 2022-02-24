using System;

namespace SandboxProject
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      string password = Console.ReadLine();
      int passwordint =  password.Length;
      if (passwordint < 10)

      {
        Console.WriteLine("Enter more word please.");
      }
      else if (passwordint == 10)
      {
        Console.WriteLine("good");     
      }
      else 
      {
        Console.WriteLine("To many my man."); 
                                              
      }
       Console.WriteLine("Conflict ddi ban oi")
    }
  }
} 
