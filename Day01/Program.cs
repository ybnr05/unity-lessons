using System;

class Program
{
    
    static void Main()
    {
        Console.Write("Enter player name: ");
        string playername = Console.ReadLine()!;
        Console.Write("Enter Health");
        int health = int.Parse(Console.ReadLine()!);

        if (health > 0)
        {
            Console.WriteLine("Status: Alive");
        }
        else
        {
            Console.WriteLine("Status: Dead");
        }

        Console.Write("Enter level");
        int level = int.Parse(Console.ReadLine()!);
        if (level>=10)
        {
            Console.WriteLine("Rank: Best player");
        }
        else
        {
            Console.WriteLine("Rank: worst player");
        }
        
        Console.WriteLine();
        Console.WriteLine("=========================");
        Console.WriteLine("PLAYER REPORT");
        Console.WriteLine("=========================");
        

        Console.WriteLine("Name:" + playername);
        Console.WriteLine("Health:" + health);
        Console.WriteLine("Level" + level);
        
        
    }
}