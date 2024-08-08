using System;
namespace Lambda_Expression;

public class Program
{
    delegate bool IsAdult(Student stud);

    public static void Main()
    {
        IsAdult isAdult = (s) =>

        { 

            //statement 01. local variable
            int adultAge = 18; 

            //statement 02. print a message
            Console.WriteLine("Lambda expression with multiple statements in the body");
            
            //statement 03. check if age is greater or equal 18
            return s.Age >= adultAge;
        };



        Student stud = new Student() { Age = 25 };

        Console.WriteLine(isAdult(stud));


    }
}