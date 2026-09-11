using System;

class Program
{
    static void Main()
    {
        int secretNumber = 7;
        int guess = 0;

        while (guess != secretNumber)
        {
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > secretNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too Low!");
            }
        }

        Console.WriteLine("Congratulations!");
    }
}