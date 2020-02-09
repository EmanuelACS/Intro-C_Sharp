using System;

public class Draw
{
    public void Diamond(int diamondBase)
    {
        int iterations = (diamondBase + 1)/2;

        for (int i = 1; i <= iterations; i++)
        {
            for (int j = 0; j < (iterations - i); j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (int k = 1; k < i; k++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        for (int i = iterations - 1; i >= 1; i--)
        {
            for (int j = 0; j < (iterations - i); j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            for (int k = 1; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void Triangle(int triangleBase)
    {
        for (int i = 1; i <= triangleBase; i++)
        {
            for (int j = triangleBase; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}

public class Program
{
    public static void Main()
    {

        Draw canvas = new Draw();

        Console.WriteLine("Enter 1 to print a diamond, enter 2 to print a triangle");

        int shape = Convert.ToInt32(Console.ReadLine());

        switch (shape)
        {
            case 1:
                canvas.Diamond(9);
                break;
            case 2:
                canvas.Triangle(9);
                break;
        }
    }
}
