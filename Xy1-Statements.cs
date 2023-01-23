using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("||Calculate what series will come next on question 7||");
      
        Console.Write("Enter what will come next as X: ");
        int X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter what will come next as Y: ");
        int Y = Convert.ToInt32(Console.ReadLine());

        int N = 1;
      
        double sum = 0;
        while (N <= X)
        {
            sum += (N / Math.Pow(Y, N + 1));
            N++;
        }
        Console.WriteLine("Y = " + sum);
    }
}
