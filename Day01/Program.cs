using System;

class Player
{
    public string Name;
    public int Health;

    public static int PlayerCount = 0;

    public Player(string name, int health)
    {
        Name = name;
        Health = health;

        PlayerCount++;
    }

    public void DisplayPlayer()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health);
    }

    public static void DisplayPlayerCount()
    {
        Console.WriteLine("Total Players: " + PlayerCount);
    }
}

class Program
{
    static void Main()
    {
        Player player1 = new Player("Bhuvan", 100);
        Player player2 = new Player("Alex", 75);
        Player player3 = new Player("John", 50);

        player1.DisplayPlayer();
        Console.WriteLine();

        player2.DisplayPlayer();
        Console.WriteLine();

        player3.DisplayPlayer();
        Console.WriteLine();

        Player.DisplayPlayerCount();
    }
}