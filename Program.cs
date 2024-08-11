using System;
namespace Lambda_Expression;


public class Program
{


    public static void Main()
    {
        Action<Student> PrintStudentDetail = s =>
        Console.WriteLine("Name: {0}, Age: {1} ", s.StudentName, s.Age);

        Student std = new Student() { StudentName = "Bill", Age = 21 };

        PrintStudentDetail(std);


    }
}//The output is Name: Bill, Age: 21