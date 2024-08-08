using System;
namespace Lambda_Expression;


public class Program
{
    delegate bool IsYoungerThan(Student stud, int youngAge);

    public static void Main()
    {
        IsYoungerThan isYoungerThan = (s, youngAge) =>
        {
            //statement 01.
            Console.WriteLine("Lambda expression with multiple statements in the body");

            //statement 02.
            return s.Age < youngAge;
        };

        Student stud = new Student() { Age = 25 };

        Console.WriteLine(isYoungerThan(stud, 26));

    }
}