using System;
using System.Linq;

public class Program
{
    static int Compare(int a, int b)
    {
        int[] arr = {a, b};
        return arr.Max();
    }

    static int Compare(int a, int b, int c)
    {
        int[] arr = {a, b, c};
        return arr.Max();
    }

    static void Main(string[] args)
    {
        int int1, int2, int3;

        Console.Write("Please enter your first integer: ");
        int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter your second integer: ");
        int2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter your third integer: ");
        int3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Compare(int1, int2));
        Console.WriteLine(Compare(int1, int2, int3));
    }
}