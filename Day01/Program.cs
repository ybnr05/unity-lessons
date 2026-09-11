using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========== WHILE LOOP PRACTICE ==========");
        Console.WriteLine("1. Countdown");
        Console.WriteLine("2. Password Checker");
        Console.WriteLine("3. Guess the Number");

        Console.Write("Choose an option: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:

                int count = 10;

                while (count >= 1)
                {
                    Console.WriteLine(count);
                    count--;
                }

                Console.WriteLine("Blast Off!");
                break;

            case 2:

                string password = "";

                while (password != "csharp")
                {
                    Console.Write("Enter Password: ");
                    password = Console.ReadLine();

                    if (password != "csharp")
                    {
                        Console.WriteLine("Wrong Password!");
                    }
                }

                Console.WriteLine("Access Granted!");
                break;

            case 3:

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
                break;

            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
    }
}