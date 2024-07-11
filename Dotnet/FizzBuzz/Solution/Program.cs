public class FizzBuzz
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> wordVals = new Dictionary<int, string>();
        wordVals.Add(3, "Fizz");
        wordVals.Add(5, "Buzz");
        wordVals.Add(7, "Bang");
        wordVals.Add(9, "Crack");
        
        bool next = true;
        var rand = new Random();
        bool playerTurn = (rand.Next() % 2 == 0);

        Console.WriteLine("Welcome to FizzBuzz!\nWhat number would you like to begin at?");
        Console.Write("Starting Number: ");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("On a 2 - infinite scale, choose your difficulty (the larger the number, the harder the game is! Seriously, we're not kidding about this!)");
        Console.Write("Difficulty: ");
        int difficulty = int.Parse(Console.ReadLine());

        Console.WriteLine( i + ": " + FizzBuzzBuilder(i, wordVals));
        i++;

        while (next) 
        {
        // Set the players turn, reset the random value passed to the computer, 
        //     and calculate the correct answer for the round.
            playerTurn = !playerTurn;
            int rnd = 0;
            string corAnswer = FizzBuzzBuilder(i, wordVals);
            string? currentAnswer;

        // Determine if the computer will be right or wrong if it pays this turn
            if (rand.Next() % difficulty == 0)
                rnd = rand.Next() % 10;

        // Collect the players answer, or the computers answer for the current turn
            if ( playerTurn )
            {
                Console.Write("Your turn: ");
                currentAnswer = Console.ReadLine();
            }
            else
            {
                currentAnswer = FizzBuzzBuilder(i+rnd, wordVals);
                Console.WriteLine(currentAnswer);
            }

        // Determine if the answer was correct, and if the player or computer has lost
            if (currentAnswer != corAnswer && playerTurn)
            {
                Console.Write("Better luck next time!");
                next = false;
            }
            else if (currentAnswer != corAnswer)
            {
                Console.WriteLine("You Won on difficulty {0}", difficulty);
                next = false;
            }
            else
                i++;     
        }
    }

    public static string FizzBuzzBuilder(int i, Dictionary<int, string> wordVals)
    {
        string output = "";
        
        foreach(KeyValuePair<int, string> val in wordVals)
        {
            if (i % val.Key == 0 )
                output += val.Value;
        }

        if (String.IsNullOrEmpty(output))
            output += i.ToString();

        return output;
    }
}