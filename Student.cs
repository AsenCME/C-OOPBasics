using System;
using System.Text.RegularExpressions;

internal class Student : Human
{
    private string _number;

    public Student(string fName, string sName, string fNumber)
        : base(fName, sName)
    {
        FacultyNumber = fNumber;
    }

    private string FacultyNumber
    {
        get => _number;
        set
        {
            if (IsNumberInvalid(value))
                throw new ArgumentException("Invalid faculty number!");
            _number = value;
        }
    }

    private static bool IsNumberInvalid(string value)
    {
        var numberPattern = @"^([0-9a-zA-Z]{5,10})$";
        var regex = new Regex(numberPattern);
        var match = regex.Match(value);
        if (match.Success)
            return false;
        return true;
    }

    public override string ToString()
    {
        return $"\nFirst Name: {FirstName}" +
               $"\nLast Name: {LastName}" +
               $"\nFaculty number: {FacultyNumber}";
    }
}