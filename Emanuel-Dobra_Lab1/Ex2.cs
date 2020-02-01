// Write a C# application that converts temperature reading (in degree Celsius, entered by the user) to Fahrenheit and vice-versa. 
using System;

public class Program {
    public static void Main (string[] args) {
        string userInput1, convertOperation;
        int conversionResult;
        Console.Write ("Enter CF to convert Celsius to Fahrenheit or FC to covert Fahrenheit to Celsius: ");
        convertOperation = Console.ReadLine ();

        if (convertOperation == "CF") {
            Console.Write ("Please enter the Celsius value: ");
            userInput1 = Console.ReadLine ();

            int a = Convert.ToInt32 (userInput1);
            conversionResult = ((a * 9 / 5) + 32);
            Console.WriteLine ("Fahrenheit: {0}", conversionResult);
        } else if (convertOperation == "FC") {
            Console.Write ("Please enter the Fahrenheit value: ");
            userInput1 = Console.ReadLine ();

            int a = Convert.ToInt32 (userInput1);
            conversionResult = ((a - 32) * 5 / 9);
            Console.WriteLine ("Celsius: {0}", conversionResult);
        } else {
            Console.WriteLine ("Input Error");
        }
    }
}