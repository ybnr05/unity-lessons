using System;

class Program
{
    static void Main()
    {
        for (int i = 10; i >= 1; i--)
        {
            

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }
}