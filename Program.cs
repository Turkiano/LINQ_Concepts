using System;
namespace Lambda_Expression;


public class Program
{


    public static void Main()
    {
        //assigning Lambda to the built-in Delegate (Func)
        Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

        Student stud = new Student() { Age = 21 };

        Console.WriteLine(isStudentTeenAger(stud));


    }
} //the output is false, since 21 is greater than 20