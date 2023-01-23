using System;

class Program {

  public static void Main (string[] args) {
    
    int spaces=101, i=1, sum = 0; 
    Random rnd = new Random();


    while (i<spaces){
    int randomnumbers = rnd.Next(-100,100);
  
      sum = sum + randomnumbers;
  
      Console.WriteLine(randomnumbers);
  
      i++;

      if(i == spaces) 
      {
        
        Console.WriteLine("The Sum is: " + " " + sum);  
      }
      
  }


 }
}
  
      
