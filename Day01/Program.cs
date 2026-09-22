namespace CodeMonkey.CSharpCourse.L1540_RockPaperScissors;

public class RockPaperScissors
{
    /* ** Rock Paper Scissors **
     *
     * There are 3 Actions
     * Rock, Paper, Scissors
     *
     * Rock beats Scissors
     * Scissors beats Paper
     * Paper beats Rock
     *
     * Computer generates Action
     * Asks player for input
     * Prints result
     *
     * Hint: You can generate random numbers with new System.Random().Next(3);
     *       Generates between 0 (inclusive) and 3 (exclusive)
     * */
    public RockPaperScissors()
    {
        string computerAction;

        switch (GenerateRandomNumber())
        {
            default:
            case 0:
                computerAction = "Rock";
                break;
            case 1:
                computerAction = "Paper";
                break;
            case 2:
                computerAction = "Scissors";
                break;
        }

        Console.WriteLine("Computer has generated Action...");
        Console.WriteLine("Choose your Action: (Rock, Paper, Scissors)");

        string? playerInput = Console.ReadLine();
        string playerAction = playerInput?.Trim() ?? string.Empty;

        if (playerAction.Equals("rock", StringComparison.OrdinalIgnoreCase))
        {
            playerAction = "Rock";
        }
        else if (playerAction.Equals("paper", StringComparison.OrdinalIgnoreCase))
        {
            playerAction = "Paper";
        }
        else if (playerAction.Equals("scissors", StringComparison.OrdinalIgnoreCase))
        {
            playerAction = "Scissors";
        }
        else
        {
            Console.WriteLine("Invalid action. Please choose Rock, Paper, or Scissors.");
            return;
        }

        Console.WriteLine("-");
        Console.WriteLine("Player Plays <color=#ffff00>" + playerAction + "</color>");
        Console.WriteLine("Computer Plays <color=#ffff00>" + computerAction + "</color>");

        switch (playerAction)
        {
            default:
                break;
            case "Rock":
                switch (computerAction)
                {
                    case "Rock":
                        Console.WriteLine("<color=#00ffff>Tie</color>");
                        break;
                    case "Paper":
                        Console.WriteLine("Paper beats Rock, <color=#ffff00>Computer wins!</color>");
                        break;
                    case "Scissors":
                        Console.WriteLine("Rock beats Scissors, <color=#00ff00>Player wins!</color>");
                        break;
                }
                break;
            case "Paper":
                switch (computerAction)
                {
                    case "Rock":
                        Console.WriteLine("Paper beats Rock, <color=#00ff00>Player wins!</color>");
                        break;
                    case "Paper":
                        Console.WriteLine("<color=#00ffff>Tie</color>");
                        break;
                    case "Scissors":
                        Console.WriteLine("Scissors beats Paper, <color=#ffff00>Computer wins!</color>");
                        break;
                }
                break;
            case "Scissors":
                switch (computerAction)
                {
                    case "Rock":
                        Console.WriteLine("Rock beats Scissors, <color=#ffff00>Computer wins!</color>");
                        break;
                    case "Paper":
                        Console.WriteLine("Scissors beats Paper, <color=#00ff00>Player wins!</color>");
                        break;
                    case "Scissors":
                        Console.WriteLine("<color=#00ffff>Tie</color>");
                        break;
                }
                break;
        }
    }

    private int GenerateRandomNumber()
    {
        // Generates a random number between 0 (include) and 3 (exclusive)
        return new Random().Next(3);
    }
}

public class Program
{
    public static void Main()
    {
        _ = new RockPaperScissors();
    }
}