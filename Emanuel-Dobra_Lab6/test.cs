using System;

public class Developer
{
    public string name;
    public int salary;

    public satic void Main(string[] args) 
    {

    }

    public setName(string fullName)
    {
        name = fullName; 
    }

    public setSalary(int hourlyySalary)
    {  
        salary = hourlySalary;

    }

    public displayInfo()
    {   
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Salary: {0}", salary);
    }
}

class Program
{
    public static void Main (string[] args) {
        Developer user = new Developer();

        user.displayInfo();
    }
}
