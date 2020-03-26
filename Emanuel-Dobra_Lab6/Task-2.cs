using System;
class SavingsAccount
{
    public SavingsAccount(double balance, string accountName)
    {
        savingsBalance = balance;
        Console.WriteLine("{0}'s current balance: {1}$", accountName, Math.Round(savingsBalance, 2));
        Console.WriteLine("-------------------------------------");

    }
    public static double annualInterestRate { get; set; }
    private double savingsBalance { get; set; }
    public void CalculateMonthlyInterest()
    {
        double monthlyInterest = (savingsBalance * annualInterestRate) / 12;
        savingsBalance += monthlyInterest;
        Console.WriteLine("Your Monthly interest is {0}$", Math.Round(monthlyInterest, 2));
        Console.WriteLine("Your new balance is {0}$", Math.Round(savingsBalance, 2));
        Console.WriteLine("-------------------------------------");

    }
    public static void ModifyInterestRate(double newRate)
    {
        annualInterestRate = newRate;
        Console.WriteLine("The interest rate is now {0}%", Math.Round(annualInterestRate * 100, 2));
        Console.WriteLine("-------------------------------------");

    }
}


public class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount saver1 = new SavingsAccount(2000.00, "saver1");
        SavingsAccount saver2 = new SavingsAccount(3000.00, "saver2");
        SavingsAccount.ModifyInterestRate(0.04);
        saver1.CalculateMonthlyInterest();
        saver2.CalculateMonthlyInterest();

        SavingsAccount.ModifyInterestRate(0.05);
        saver1.CalculateMonthlyInterest();
        saver2.CalculateMonthlyInterest();

    }
}