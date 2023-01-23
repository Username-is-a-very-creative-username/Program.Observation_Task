using System;

class Program {

  
  public static void Main (string[] args) {
    
    int spaces=101;
    Random rnd = new Random();
    int evennumbercount = 0, unevennumbercount = 0;
    int [] randomNumList = new int [spaces];


  
    for(int j=1; j<spaces; j++) {
    randomNumList[j] = rnd.Next(1,100);
    Console.WriteLine(randomNumList[j]);

      if (randomNumList[j]%2 == 0)
      {
         evennumbercount += 1;
        //Console.WriteLine("Even Number");
      }

      if (randomNumList[j]%2 == 1)
      {
        unevennumbercount += 1;
        //Console.WriteLine("Uneven Number");
      }

  }


        Console.WriteLine("The total even numbers:" + " " + evennumbercount);
    Console.WriteLine("==================================");
      Console.WriteLine("The total uneven numbers:" + " " + unevennumbercount);
    
 }
}
  
      
