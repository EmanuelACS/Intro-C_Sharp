using System;

class BankAccount
{
    public int accountNumber;
    public int balance;
    public int chargeTotal;
    public int creditsTotal;
    public int creditsLimit;

    public void BalanceCheck(int balance, int charges, int credits, int creditsLimit)
    {
        int newBalance = (balance + charges - credits);
        Console.WriteLine("Your new balance is {0}", newBalance);
        if (newBalance > creditsLimit)
        {
            Console.WriteLine("Credit limit exceeded");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        BankAccount userAccount = new BankAccount();

        Console.Write("Please enter the customer's account number: ");
        userAccount.accountNumber = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter the customer's balance at the start of the month: ");
        userAccount.balance = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter the customer's total charged this month: ");
        userAccount.chargeTotal = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter the customer's total credit applied this month: ");
        userAccount.creditsTotal = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter the customer's allowed credit limit: ");
        userAccount.creditsLimit = Int32.Parse(Console.ReadLine());

        userAccount.BalanceCheck(userAccount.balance, userAccount.chargeTotal, userAccount.creditsTotal, userAccount.creditsLimit);
    }
}