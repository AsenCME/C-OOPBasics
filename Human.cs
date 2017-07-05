using System;

internal class Human
{
    private string _firstName;
    private string _lastName;

    public Human(string fName, string sName)
    {
        FirstName = fName;
        LastName = sName;
    }

    protected string FirstName
    {
        get => _firstName;
        set
        {
            if (!char.IsUpper(value[0]))
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            if (value.Length < 4)
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            _firstName = value;
        }
    }

    protected string LastName
    {
        get => _lastName;
        set
        {
            if (!char.IsUpper(value[0]))
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            if (value.Length < 3)
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            _lastName = value;
        }
    }
}