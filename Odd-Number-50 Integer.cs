using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("WHILE:");
        int i = 1, j = 1;
        while (i < 49)
        {

            i = i + 2;
            Console.WriteLine(i);

            if (i == 49)
            {
                Console.WriteLine(i + 1);
            }

        }


        Console.WriteLine(" DO WHILE:");
        do
        {
            j = j + 2;
            Console.WriteLine(j);

            if (j == 49)
            {
                Console.WriteLine(j + 1);
            }
        }
        while (j < 49);



        Console.WriteLine("FOR LOOP:");

        for (int p = 1; p < 50; p++)
        {
            Console.WriteLine(p);
            p++;


        }
        for (int k = 50; k < 51; k++)
        {

            Console.WriteLine(k);


        }

    }
}
