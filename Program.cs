using System;
class Program
{
    static void Main()
    {
        try
        {
            var line = Console.ReadLine().Split(' ');
            Console.WriteLine(new Student(line[0], line[1], line[2]).ToString());
            line = Console.ReadLine().Split(' ');
            Console.WriteLine(new Worker(line[0], line[1], double.Parse(line[2]), double.Parse(line[3])));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}