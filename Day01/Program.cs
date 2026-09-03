using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name:");
        string playerName = Console.ReadLine();
        Console.Write("Enter  level: ");
        int level = int.Parse(Console.ReadLine());

        Console.Write("Enter Health:");
        int health = int.Parse(Console.ReadLine());
        Console.Write("Enter Gold");
        int gold = int.Parse(Console.ReadLine());
        Console.Write("Enter Speed:");
        int speed = int.Parse(Console.ReadLine());

        int levelAfter = level + 1;
        int healthfter = health + 10;
        int goldAfrer = gold + 50;
        Console.WriteLine();
        Console.WriteLine("===========");
        Console.WriteLine("Character Report");
        Console.WriteLine("===========");
        Console.WriteLine("Name: " + playerName);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Gold: " + gold);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine();
        Console.WriteLine("After upgrade:");
        Console.WriteLine("Level: " + levelAfter);
        Console.WriteLine("Health: " + healthfter);
        Console.WriteLine("Gold: " + goldAfrer);
        
    }
}