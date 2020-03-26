using System;
public interface IPayable
{
    double GetPaymentAmount();
}

public class Invoice : IPayable
{
    public int quantity { get; set; }
    public double pricePerItem { get; set; }

    public Invoice(int itemQuantity, double itemPrice)
    {
        quantity = itemQuantity;
        pricePerItem = itemPrice;
    }

    public override string ToString()
    {
        return "Quantity: " + quantity + "\n"
            + "Price per Item: " + pricePerItem + "\n";
    }

    public double GetPaymentAmount()
    {
        return quantity * pricePerItem;
    }
}

public class Employee : IPayable
{
    public void setData(string givenName, string familyName, double ssn)
    {
        firstName = givenName;
        lastName = familyName;
        socialSecurityNumber = ssn;
        
    }

    public string firstName { get; set; }
    public string lastName { get; set; }
    public double socialSecurityNumber { get; set; }

    virtual public double GetPaymentAmount()
    {
        return 0;
    }
}

public class SalariedEmployee : Employee
{
    public double weeklySalary { get; set; }

    public SalariedEmployee(string givenName, string familyName, double ssn, double salaryWeek)
    {
        firstName = givenName;
        lastName = familyName;
        socialSecurityNumber = ssn;
        weeklySalary = salaryWeek;
    }

    public override double GetPaymentAmount()
    {
        return weeklySalary;
    }

    public override String ToString()
    {
        return "Name: " + this.firstName + " " + this.lastName + "\n" +
            "SSN: " + this.socialSecurityNumber + "\n";
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        IPayable[] ipObjects = new IPayable[4];

        ipObjects[0] = new Invoice(93, 42.75);
        ipObjects[1] = new SalariedEmployee("Sammy", "Gertrude", 743923731, 625.75);

        Console.WriteLine("<<< Invoice >>>\n" + ipObjects[0].ToString() + "Payement Amount: " + ipObjects[0].GetPaymentAmount() + "\n");
        Console.WriteLine("<<< Employee >>>\n" + ipObjects[1].ToString() + "Payement Amount: " + ipObjects[1].GetPaymentAmount());
    }
}