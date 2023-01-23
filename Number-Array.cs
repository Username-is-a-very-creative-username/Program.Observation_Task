using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine ("Enter 6 Numbers which will be stored in the array");
int a,b,c,d,e,f; 
      {
       a= Convert.ToInt32(Console.ReadLine());
      b=Convert.ToInt32(Console.ReadLine());
      c= Convert.ToInt32(Console.ReadLine());
      d= Convert.ToInt32(Console.ReadLine());
      e=Convert.ToInt32(Console.ReadLine());
      f= Convert.ToInt32(Console.ReadLine());
      }
    Console.WriteLine ("___________________________");
     
      int[] numbers = {a,b,c,d,e,f};
Console.WriteLine (numbers[0]);
Console.WriteLine (numbers[1]);
Console.WriteLine (numbers[2]);
Console.WriteLine (numbers[3]);
Console.WriteLine (numbers[4]);
Console.WriteLine (numbers[5]);
    
        Console.WriteLine("The Length of the array is {0}",numbers.Length);  
    }
}
