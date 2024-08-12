using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambda_Expression;

public class Program
{
    public static void Main()
    {
        // Student collection (data source)
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

        //lambda expression with Func delegate
        Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

        //filtering students using LINQ (Method Syntax)
        var teenAgerStudent = studentList.Where(isStudentTeenAger);

        //print a header to the console
        Console.WriteLine("Teen age Students:");

        //Executation			  
        foreach (Student std in teenAgerStudent)
        {
            Console.WriteLine($"Student: {std.StudentName} {std.Age}");
        }
    }
}