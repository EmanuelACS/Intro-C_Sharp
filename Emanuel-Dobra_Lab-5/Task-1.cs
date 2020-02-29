// 200$ + 9% sales

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] salaryCounter = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int salary;
        Console.WriteLine("Enter user's total sales this week or -1 to quit");
        int sales = Convert.ToInt32(Console.ReadLine());

        while (sales != -1)
        {
            salary = Convert.ToInt32(200 + (sales * 0.09));

            if (salary >= 200 && salary < 300)
            {
                salaryCounter[0]++;
            }
            else if (salary >= 300 && salary < 400)
            {
                salaryCounter[1]++;
            }
            else if (salary >= 400 && salary < 500)
            {
                salaryCounter[2]++;
            }
            else if (salary >= 500 && salary < 600)
            {
                salaryCounter[3]++;
            }
            else if (salary >= 600 && salary < 700)
            {
                salaryCounter[4]++;
            }
            else if (salary >= 700 && salary < 800)
            {
                salaryCounter[5]++;
            }
            else if (salary >= 800 && salary < 900)
            {
                salaryCounter[6]++;
            }
            else if (salary >= 900 && salary < 1000)
            {
                salaryCounter[7]++;
            }
            else if (salary >= 1000)
            {
                salaryCounter[8]++;
            }
            Console.WriteLine("Enter user's total sales this week or -1 to quit");
            sales = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Earnings Range: |$200 - $299|$300 - $399|$400 - $499|$500 - $599|$600 - $699|$700 - $799|$800 - $899|$900 - $999|$1000 and over|");
        Console.Write("Sales Results:  ");
        for (int j = 0; j < 9; j++)
        {
            Console.Write("|" + salaryCounter[j] + ",         ");
        }
        Console.WriteLine();
    }
}
