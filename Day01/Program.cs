public class Quiz
{
    /* ** Quiz **
     *
     * Implement Questions and Answers
     * Ask player the question, player answers
     * Check if answer is correct
     * Keep asking questions until there`s no more
     *
     * Hint: You can store multiple pieces of data in one variable using collections
     * For example a List<string> or a string[] array
     * Then you can cycle through it with: for (int i = 0; i < list.Count; i++) {   }
     * */
    public Quiz()
    {
        List<string> questionList = new List<string>()
        {
            "What is the Capital of USA?",
            "How much is 16*6?",
            "Who is the author of rich dad poor dad?",
        };

        List<string> answerList = new List<string>()
        {
            "Washington, D.C.",
            "96",
            "Robert Kiyosaki",
        };

        Console.WriteLine("## Quiz! ##");
        for (int questionIndex = 0; questionIndex < questionList.Count; questionIndex++)
        {
            Console.WriteLine(questionList[questionIndex]);
            string answer = Console.ReadLine() ?? string.Empty;

            if (answer == answerList[questionIndex])
            {
                WriteLineCorrect();
            }
            else
            {
                WriteLineIncorrect();
                Console.WriteLine("Correct Answer: " + answerList[questionIndex]);
            }
        }
    }

    private static void WriteLineCorrect()
    {
        Console.WriteLine("Correct!");
    }

    private static void WriteLineIncorrect()
    {
        Console.WriteLine("Incorrect!");
    }
}

public class Program
{
    public static void Main()
    {
        _ = new Quiz();
    }
}