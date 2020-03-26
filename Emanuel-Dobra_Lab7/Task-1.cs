using System;

public class CommissionEmployee
{
    public void setData(string givenName, string familyName, double ssn, double gSales, double cRate)
    {
        firstName = givenName;
        lastName = familyName;
        socialSecurityNumber = ssn;
        grossSales = gSales;
        commissionRate = cRate;
    }

    public string firstName { get; set; }
    public string lastName { get; set; }
    public double socialSecurityNumber { get; set; }
    public double grossSales { get; set; }
    public double commissionRate { get; set; }

    public override String ToString()
    {
        return "Name: " + this.firstName + " " + this.lastName + "\n" +
            "SSN: " + this.socialSecurityNumber + "\n" +
            "Gross Sales: " + this.grossSales + "\n" +
            "Commission Rate" + this.commissionRate + "\n";
    }

    public virtual double Earnings()
    {
        return commissionRate * grossSales;
    }
}

public class BasePlusComissionEmployee : CommissionEmployee
{
    public BasePlusComissionEmployee(string givenName, string familyName, double ssn, double gSales, double cRate, double salary)
    {
        firstName = givenName;
        lastName = familyName;
        socialSecurityNumber = ssn;
        grossSales = gSales;
        commissionRate = cRate;
        baseSalary = salary;
    }
    public double baseSalary { get; set; }
    public override double Earnings()
    {
        return baseSalary + (commissionRate * grossSales);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CommissionEmployee employeeC = new CommissionEmployee();
        employeeC.setData("Terry", "Harbos", 100523153, 300.25, 0.08);
        Console.WriteLine(employeeC.ToString());
        Console.WriteLine("Earnings: " + employeeC.Earnings());

        BasePlusComissionEmployee employeeB = new BasePlusComissionEmployee("Terry", "Harbos", 100523153, 300.25, 0.10, 25.00);
        Console.WriteLine("Earnings: " + employeeB.Earnings());
    }
}