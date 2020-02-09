using System;

public class Program
{
    public static void Main(string[] args)
    {
        float[] myArray = new float[6];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Input a positive number");
            myArray[i] = float.Parse(Console.ReadLine());

            while (myArray[i] < 0)
            {
                Console.Write("Invalid, please try again: ");
                myArray[i] = float.Parse(Console.ReadLine());
            }
        }

        float arraySum = 0;

        for (int j = 0; j < 5; j++)
        {
            arraySum = arraySum + myArray[j];
        }

        float arrayAverage = arraySum / 5;

        Console.WriteLine("The sum of your numbers is: " + arraySum);
        Console.WriteLine("The average of your numbers is: " + arrayAverage);
    }
}