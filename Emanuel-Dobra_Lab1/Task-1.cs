//Print the sum, difference and product of the two numbers
using System;

public class Program {
    public static void Main (string[] args) {
        string userInput1, userInput2;
        Console.Write ("Please enter your first integer: ");
        userInput1 = Console.ReadLine ();

        Console.Write ("Please enter your second integer: ");
        userInput2 = Console.ReadLine ();

        int a = Convert.ToInt32 (userInput1);
        int b = Convert.ToInt32 (userInput2);
        Console.WriteLine ("Sum: {0}", a + b);
        Console.WriteLine ("Difference: {0}", a - b);
        Console.WriteLine ("Product: {0}", a * b);
    }
}