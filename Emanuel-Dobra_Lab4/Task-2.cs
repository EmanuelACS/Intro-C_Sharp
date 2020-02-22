using System;

public class GuessingGame
{
    public int GenerateSecret()
    {
        Random random = new Random();
        return random.Next(1000);
    }
    public void CheckGuess(int guess, int secret)
    {
        int tries = 0;
        bool correct = false;
        string playAgain;
        while (!correct)
        {
            if (guess < secret)
            {
                tries++;
                Console.WriteLine("Too low!");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            else if (guess > secret)
            {
                tries++;
                Console.WriteLine("Too High!");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            else if (guess == secret && tries < 10)
            {
                Console.WriteLine("\n" + "I think you know the secret!");

                Console.WriteLine("\n" + "Excellent!");
                Console.WriteLine("Would you like to play again (y/n)?");
                playAgain = Console.ReadLine();

                if (playAgain == "n")
                {
                    correct = true;
                }
                else if (playAgain == "y")
                {
                    secret = GenerateSecret();
                    tries = 0;

                    Console.WriteLine("\n" + "I have a number between 1 and 1000." + "( " + secret + " )");
                    Console.WriteLine("Please enter your first guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("\n" + "You can do better!");

                Console.WriteLine("\n" + "Excellent!");
                Console.WriteLine("Would you like to play again (y/n)?");
                playAgain = Console.ReadLine();
                if (playAgain == "n")
                {
                    correct = true;
                }
                else if (playAgain == "y")
                {
                    secret = GenerateSecret();
                    tries = 0;

                    Console.WriteLine("\n" + "I have a number between 1 and 1000." + "( " + secret + " )");
                    Console.WriteLine("Please enter your first guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GuessingGame userTry = new GuessingGame();

        int secret = userTry.GenerateSecret();
        int userInput;

        Console.WriteLine("I have a number between 1 and 1000." + "( " + secret + " )");
        Console.WriteLine("Please enter your first guess: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        userTry.CheckGuess(userInput, secret);
    }
}
