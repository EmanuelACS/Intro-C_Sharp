using System;

class Student
{
    public Student()
    {
        Console.Write("Please enter the student's id: ");
        studentId = Int64.Parse(Console.ReadLine());

        Console.Write("Please enter the student's first name: ");
        firstName = Console.ReadLine();

        Console.Write("Please enter the student's last name: ");
        lastName = Console.ReadLine();

        Console.Write("Please enter the student's home address: ");
        address = Console.ReadLine();

        Console.Write("Please enter the name of the city the student lives in: ");
        city = Console.ReadLine();

        Console.Write("Please enter the province the student resides in: ");
        province = Console.ReadLine();

        Console.Write("Please enter the student's email: ");
        email = Console.ReadLine();

        Console.Write("Please enter the student's phone number: ");
        phoneNumber = Console.ReadLine();

    }

    public long studentId { get; set; }
    public string phoneNumber { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string province { get; set; }
    public string email { get; set; }

    public void BasicInfo()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("{0} {1}'s id is {2}", firstName, lastName, studentId);
    }

    public void Address()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("The student lives on {0} in {1}, {2}", address, city, province);
    }

    public void ContactInfo()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Phone: {0}", phoneNumber);
        Console.WriteLine("Email: {0}", email);
    }

    public void ListStudentInfo()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("ID: {0}", studentId);
        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("City: {0}", city);
        Console.WriteLine("Province: {0}", province);
        Console.WriteLine("Email: {0}", email);
        Console.WriteLine("Phone: {0}", phoneNumber);
    }

    ~Student()
    {
        Console.WriteLine("The instance of Student class was Destroyed");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();

        Console.WriteLine("Type 'basic' to see the student's basic information.");
        Console.WriteLine("Type 'address' to see the student's address.");
        Console.WriteLine("Type 'contact' to see the student's contact information.");
        Console.WriteLine("Type 'all' to see all of the student's information.");
        string display = Console.ReadLine();

        switch (display)
        {
            case "basic":
                student1.BasicInfo();
                break;
            case "address":
                student1.Address();
                break;
            case "contact":
                student1.ContactInfo();
                break;
            case "all":
                student1.ListStudentInfo();
                break;
        }

    }
}