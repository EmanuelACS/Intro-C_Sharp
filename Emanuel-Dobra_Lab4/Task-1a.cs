using System;

public class Program
{
    static void PassValue(int number)
    {
        Console.WriteLine("Your number is " + number);
    }
    static void PassReference(ref int number)
    {
        Console.WriteLine("Your number is " + number);
    }

    static void OutParameter(out int number)
    {
        number = 11;
        Console.WriteLine(number);
    }

    static void DeclareArray(params int[] args)
    {
        foreach (int j in args)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int userInput;
        int num;
        Console.Write("Please enter your integer: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        PassValue(userInput);
        PassReference(ref userInput);
        OutParameter(out num);
        DeclareArray(1, 2, 3, 4);
    }
}
