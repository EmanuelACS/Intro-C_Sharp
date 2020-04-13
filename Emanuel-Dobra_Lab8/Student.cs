using System;
class Student
{
    public String firstName { get; set; }
    public String lastName { get; set; }
    public Double gradesPercantage { get; set; }

    public Student(String givenName, String familyName, double gradesPercent)
    {
        firstName = givenName;
        lastName = familyName;
        if (gradesPercent >= 40 && gradesPercent <= 100)
        {
            gradesPercantage = gradesPercent;
        }
        else
        {
            throw new System.ArgumentOutOfRangeException("gradesPercent");
        }
    }


    public override string ToString()
    {
        return "Name: " + firstName + " " + lastName + "\n"
            + "Grade: " + gradesPercantage + "\n";
    }

}