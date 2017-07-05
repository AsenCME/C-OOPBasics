using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Worker : Human
{
    private double _salary;
    private double _perDay;

    public Worker(string fName, string sName, double salary, double perDay)
        : base(fName, sName)
    {
        WeekSalary = salary;
        HoursPerDay = perDay;
    }

    private double WeekSalary
    {
        get => _salary;
        set
        {
            if(value < 10)
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            _salary = value;
        }
    }
    private double HoursPerDay
    {
        get => _perDay;
        set
        {
            if(value < 1 || value > 12)
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            _perDay = value;
        }
    }
    private double SalaryPerHour => WeekSalary / (HoursPerDay * 5);

    public override string ToString()
    {
        return $"\nFirst Name: {FirstName}" +
               $"\nLast Name: {LastName}" +
               $"\nWeek Salary: {WeekSalary:F2}" +
               $"\nHours per day: {HoursPerDay:F2}" +
               $"\nSalary per hour: {SalaryPerHour:F2}";
    }
}
