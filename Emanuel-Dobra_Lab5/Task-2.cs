using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int firstRoll, secondRoll, rollSum;

        int[] myArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for (int i = 0; i < 36000; i++)
        {
            firstRoll = random.Next(6) + 1;
            secondRoll = random.Next(6) + 1;
            rollSum = firstRoll + secondRoll;

            switch (rollSum)
            {
                case 2:
                    myArray[0]++;
                    break;
                case 3:
                    myArray[1]++;
                    break;
                case 4:
                    myArray[2]++;
                    break;
                case 5:
                    myArray[3]++;
                    break;
                case 6:
                    myArray[4]++;
                    break;
                case 7:
                    myArray[5]++;
                    break;
                case 8:
                    myArray[6]++;
                    break;
                case 9:
                    myArray[7]++;
                    break;
                case 10:
                    myArray[8]++;
                    break;
                case 11:
                    myArray[9]++;
                    break;
                case 12:
                    myArray[10]++;
                    break;
            }
        }

        Console.WriteLine("Sums: | 2 |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  10 |  11 |  12 |");
        Console.Write("Array: ");
        for (int j = 0; j < 11; j++)
        {
            Console.Write(myArray[j] + ", ");
        }

        Console.WriteLine("\nThe die have been rolled 36000 times");
        float rollRate;

        for (int k = 0; k < 11; k++)
        {
            rollRate = myArray[k];
            rollRate = (rollRate / 36000) * 100;
            Console.WriteLine("The roll percantage of {0} was: {1}%", k + 2, rollRate);
        }
        // The results seem reasonable enough, approximately one sixth of the sum of the rolls were 7, 
        // and the total rolls for all other numbers are also within their resonable bounds 
    }
}