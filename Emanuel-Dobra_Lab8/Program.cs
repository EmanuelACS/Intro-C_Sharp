using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Student[] students = new Student[5];

        try
        {
            students[0] = new Student("John", "Kardin", 89);
            students[1] = new Student("Stewie", "Custart", 93);
            students[2] = new Student("Steve", "Braveheart", 49);
            students[3] = new Student("Jack", "Manter", 59);
            students[4] = new Student("John", "Kasimov", 70);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: Variable {0}'s value has to be within 40 and 100", ex.ParamName);
        }

        Console.WriteLine("<<< Ascending Students: >>>");
        var studentsOrdered = from student in students
                              orderby student.ToString() ascending
                              select student.ToString();

        foreach (var i in studentsOrdered)
        {
            Console.WriteLine(i);
        }

        var studentsSixty = from student in students
                            where student.gradesPercantage > 60
                            select student.ToString();

        Console.WriteLine("<<< Grade above 60: >>>");
        foreach (var j in studentsSixty)
        {
            Console.WriteLine(j);
        }

        Console.WriteLine("<<< Lowest Grade: >>>");
        var lowestGrade = (from student in students select student.gradesPercantage).Min();

        var studentLowest = from student in students
                            where student.gradesPercantage == lowestGrade
                            select student.ToString();

        foreach (var k in studentLowest)
        {
            Console.WriteLine(k);
        }

        Console.WriteLine("<<< Highest Grade: >>>");
        var highestGrade = (from student in students select student.gradesPercantage).Max();

        var studentHighest = from student in students
                             where student.gradesPercantage == highestGrade
                             select student.ToString();

        foreach (var n in studentHighest)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("<<< First Names: >>>");
        var studentsFirstName = students.Select(student => student.firstName).Distinct();

        foreach (var m in studentsFirstName)
        {   
            Console.WriteLine(m);
        }
    }
}