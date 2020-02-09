using System;

public class Program
{
    public static void Main(string[] args)
    {
        float[] myArray = new float[6];

        float checkNegative;

        int iterations = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Input a positive number");
            checkNegative = float.Parse(Console.ReadLine());

            if (checkNegative < 0) 
            {
                i = 6;
            }
            else
            {
                myArray[i] = checkNegative;
                iterations++;
            }
        }

        float arraySum = 0;

        for (int j = 0; j < 5; j++)
        {
            arraySum = arraySum + myArray[j];
        }

        float arrayAverage = arraySum / iterations;

        Console.WriteLine("The sum of your numbers is: " + arraySum);
        Console.WriteLine("The average of your numbers is: " + arrayAverage);
    }
}