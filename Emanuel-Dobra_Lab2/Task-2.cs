using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(String.Format("|N|10*N|100*N|1000*N|"));
        for (int n = 1; n < 6; n++)
        {
            Console.WriteLine(String.Format("|{0}|{1}|{2}|{3}|", n, 10 * n + "  ", 100 * n + "  ", 1000 * n + "  "));
        }
    }
}